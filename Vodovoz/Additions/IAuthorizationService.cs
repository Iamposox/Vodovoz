using InstantSmsService;
using QS.DomainModel.UoW;
using Vodovoz.Domain.Employees;

namespace Vodovoz.Additions
{
    public interface IAuthorizationService
    {
        void ResetPassword(Employee employee, string password);
        bool TryToSaveUser(Employee employee, IUnitOfWork uow);
        
    }
}