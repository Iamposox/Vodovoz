using System;
using EmailService;
using InstantSmsService;
using NLog;
using QS.Dialog.GtkUI;
using QS.DomainModel.UoW;
using QS.Project.Repositories;
using Vodovoz.Core.DataService;
using Vodovoz.Domain.Employees;
using Vodovoz.Parameters;
using Vodovoz.Tools;

namespace Vodovoz.Additions
{
    public class AuthorizationService : IAuthorizationService
    {
        public AuthorizationService(IPasswordGenerator passwordGenerator,
            MySQLUserRepository mySQLUserRepository)
        {
            this.passwordGenerator = passwordGenerator ?? throw new ArgumentNullException(nameof(passwordGenerator));
            this.mySQLUserRepository =
                mySQLUserRepository ?? throw new ArgumentNullException(nameof(mySQLUserRepository));
        }

        private readonly IPasswordGenerator passwordGenerator;
        private readonly MySQLUserRepository mySQLUserRepository;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        
        public void ResetPassword(Employee employee, string password)
        {
            IEmailService emailService = EmailServiceSetting.GetEmailService();

            if (emailService == null)
            {
                throw new Exception("Email service is null");
            }

            #region МеняемПароль

            if(employee.User == null){
                throw new Exception("Пользователь не существует");
            }

            string login = employee.User.Login ?? throw new Exception("У сотрудника не заполнено поля пользователя БД");
            mySQLUserRepository.ChangePassword(login, password);

            #endregion

            #region Отпарвляем сообщение
            
            string messageText = $"Логин: {login}\nПароль: {password}";

            EmailService.Email email = new EmailService.Email
            {
                Title = "Данные для входа в программу Доставка Воды",
                Text = messageText,
                Recipient = new EmailContact("", employee.Email),
                Sender = new EmailContact("vodovoz-spb.ru", ParametersProvider.Instance.GetParameterValue("email_for_email_delivery"))
            };

            var result = emailService.SendEmail(email);

            //Если произошла ошибка и письмо не отправлено
            if (!result.Item1)
            {
                throw new Exception("Письмо не было отправлено! Причина: " + result.Item2);
            }

            #endregion
        }

        public bool TryToSaveUser(Employee employee, IUnitOfWork uow)
        {
            IEmailService emailService = EmailServiceSetting.GetEmailService();

            var user = new User {
            	Login = employee.LoginForNewUser,
            	Name = employee.FullName,
            	NeedPasswordChange = true
            };
            bool cont = MessageDialogHelper.RunQuestionDialog($"При сохранении работника будет создан \nпользователь с логином {user.Login} \nи на " +
            	$"указанный адрес {employee.Email}\nбудет выслано письмо с временным паролем\n\t\t\tПродолжить?");
            if(!cont)
            	return false;

            var password = new Tools.PasswordGenerator().GeneratePassword(5);
            //Сразу пишет в базу
            var result = mySQLUserRepository.CreateLogin(user.Login, password);
            if(result) {
            	try {
            		mySQLUserRepository.UpdatePrivileges(user.Login, false);
            	} catch {
            		mySQLUserRepository.DropUser(user.Login);
            		throw;
            	}
                uow.Save(user);

                logger.Info("Идёт отправка сообщения");

                try
                {
                    #region Отпарвляем сообщение

                    string messageText = $"Логин: {user.Login}\nПароль: {password}";

                    EmailService.Email email = new EmailService.Email
                    {
                        Title = "Данные для входа в программу Доставка Воды",
                        Text = messageText,
                        Recipient = new EmailContact("", employee.Email),
                        Sender = new EmailContact("vodovoz-spb.ru", ParametersProvider.Instance.GetParameterValue("email_for_email_delivery"))
                    };

                    var emailResult = emailService.SendEmail(email);

                    //Если произошла ошибка и письмо не отправлено
                    if (!emailResult.Item1)
                    {
                        throw new Exception("Письмо не было отправлено! Причина: " + emailResult.Item2);
                    }

                    #endregion
                } catch (Exception ex)
                {
                    MessageDialogHelper.RunErrorDialog("Ошибка: " + ex.Message);
                }

                logger.Info("Sms успешно отправлено");
                employee.User = user;
            } else {
            	MessageDialogHelper.RunErrorDialog("Не получилось создать нового пользователя");
            	return false;
            }
            
            return true;
        }
        
        private bool SendPasswordByPhone(Employee employee, string password)
        {
	        SmsSender sender = new SmsSender(new BaseParametersProvider(), InstantSmsServiceSetting.GetInstantSmsService());

	        #region ФормированиеТелефона
			
	        string stringPhoneNumber = employee.GetPhoneForSmsNotification();
	        if (stringPhoneNumber == null){
		        MessageDialogHelper.RunErrorDialog("Не найден подходящий телефон для отправки Sms", "Ошибка при отправке Sms");
		        return false;
	        }
	        string phoneNumber = $"+7{stringPhoneNumber}";

	        #endregion
			
	        var result = sender.SendPassword(phoneNumber, employee.LoginForNewUser, password);
			
	        if(result.MessageStatus == SmsMessageStatus.Ok) {
		        MessageDialogHelper.RunInfoDialog("Sms с паролем отправлена успешно");
		        return true;
	        } else {
		        MessageDialogHelper.RunErrorDialog(result.ErrorDescription, "Ошибка при отправке Sms");
		        return false;
	        }
        }
        
        private void RemoveUserData(IUnitOfWork uow, User user)
        {
	        uow.Delete(user);
	        uow.Session.Flush();
	        mySQLUserRepository.DropUser(user.Login);
        }
        
    }
}