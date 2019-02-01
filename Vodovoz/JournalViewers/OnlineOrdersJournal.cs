using System;
using System.Linq;
using QS.DomainModel.UoW;
using QS.Project.Dialogs.GtkUI;
using QS.Project.Dialogs.GtkUI.JournalActions;
using QS.RepresentationModel.GtkUI;
using Vodovoz.Domain.Client;
using Vodovoz.Domain.OnlineStore;
using Vodovoz.Domain.Orders;
using Vodovoz.Representations;

namespace Vodovoz.JournalViewers
{
	public class OnlineOrdersJournal : RepresentationJournalDialog
	{
		public OnlineOrdersJournal() : base(new OnlineOrdersVM())
		{
		}

		protected override void ConfigureActionButtons()
		{
			ActionButtons.Add(new BindCounterpartyActionButton(this, RepresentationModel));
			ActionButtons.Add(new OpenCounterpartyActionButton(this, RepresentationModel));
			ActionButtons.Add(new CreateOrderActionButton(this, RepresentationModel));
			ActionButtons.Add(new OpenOrderActionButton(this, RepresentationModel));
		}

		public new virtual bool CompareHashName(string hashName)
		{
			return GenerateHashName() == hashName;
		}

		public static string GenerateHashName()
		{
			return nameof(OnlineOrdersJournal);
		}

		public class BindCounterpartyActionButton : RepresentationButtonBase
		{
			public BindCounterpartyActionButton(IJournalDialog dialog, IRepresentationModel representationModel) 
				: base(dialog, representationModel, "Привязать контрагента")
			{
				SetIcon(new Gdk.Pixbuf(System.Reflection.Assembly.GetExecutingAssembly(), "Vodovoz.icons.buttons.insert-link.png"));
			}

			public override void CheckSensetive(object[] selected)
			{
				button.Sensitive = selected.Length == 1 && !(selected[0] as OnlineOrdersVMNode).OrderId.HasValue;
			}

			public override void Execute()
			{
				var counterpartyFilter = new CounterpartyFilter(dialog.UoW);
				counterpartyFilter.SetAndRefilterAtOnce(x => x.RestrictIncludeArhive = false);
				var selectCounterparty = new RepresentationJournalDialog(new ViewModel.CounterpartyVM(counterpartyFilter), "Привязка контрагента");
				selectCounterparty.Tag = dialog.SelectedNodes.First();
				selectCounterparty.Mode = QS.Project.Dialogs.JournalSelectMode.Sinlge;
				selectCounterparty.ObjectSelected += SelectCounterparty_ObjectSelected;
				dialog.TabParent.AddSlaveTab(dialog, selectCounterparty);
			}

			void SelectCounterparty_ObjectSelected(object sender, JournalObjectSelectedEventArgs e)
			{
				var node = (sender as RepresentationJournalDialog).Tag as OnlineOrdersVMNode;
				using(var uow = UnitOfWorkFactory.CreateForRoot<OnlineClient>(node.OnlineClientId.Value, "Привязка онлайн клиента к контрагенту в журнале онлайн заказов.")) {
					var counterparty = uow.GetById<Counterparty>(e.GetSelectedIds().First());
					uow.Root.Counterparty = counterparty;
					uow.Save();
				}
				RepresentationModel.UpdateNodes();
			}

		}

		public class CreateOrderActionButton : RepresentationButtonBase
		{
			public CreateOrderActionButton(IJournalDialog dialog, IRepresentationModel representationModel)
				: base(dialog, representationModel, "Создать заказ", "gtk-new")
			{

			}

			public override void CheckSensetive(object[] selected)
			{
				button.Sensitive = selected.Length == 1 
					&& !(selected[0] as OnlineOrdersVMNode).OrderId.HasValue
					&& (selected[0] as OnlineOrdersVMNode).CounterpartyId.HasValue;
			}

			public override void Execute()
			{
				var node = dialog.SelectedNodes.First() as OnlineOrdersVMNode;
				var onlineOrder = dialog.UoW.GetById<OnlineOrder>(node.Id);
				var orderDlg = new OrderDlg(onlineOrder);
				orderDlg.Tag = node;
				orderDlg.EntitySaved += OrderDlg_EntitySaved;
				dialog.TabParent.AddSlaveTab(dialog, orderDlg);
			}

			void OrderDlg_EntitySaved(object sender, QS.Tdi.EntitySavedEventArgs e)
			{
				var node = (sender as OrderDlg).Tag as OnlineOrdersVMNode;
				using(var uow = UnitOfWorkFactory.CreateForRoot<OnlineOrder>(node.Id, "Привязка онлайн-заказа к новому заказу в журнале онлайн-заказов.")) {
					uow.Root.Order = e.Entity as Order;
					uow.Save();
				}
				RepresentationModel.UpdateNodes();
			}
		}

		public class OpenCounterpartyActionButton : RepresentationButtonBase
		{
			public OpenCounterpartyActionButton(IJournalDialog dialog, IRepresentationModel representationModel)
				: base(dialog, representationModel, "Открыть контрагента", "gtk-edit")
			{

			}

			public override void CheckSensetive(object[] selected)
			{
				button.Sensitive = selected.Length == 1 && (selected[0] as OnlineOrdersVMNode).CounterpartyId.HasValue;
			}

			public override void Execute()
			{
				var id = dialog.SelectedNodes.OfType<OnlineOrdersVMNode>().First().CounterpartyId.Value;
				dialog.TabParent.OpenTab<CounterpartyDlg, int>(id, dialog);
			}
		}

		public class OpenOrderActionButton : RepresentationButtonBase
		{
			public OpenOrderActionButton(IJournalDialog dialog, IRepresentationModel representationModel)
				: base(dialog, representationModel, "Открыть заказ", "gtk-edit")
			{

			}

			public override void CheckSensetive(object[] selected)
			{
				button.Sensitive = selected.Length == 1 && (selected[0] as OnlineOrdersVMNode).OrderId.HasValue;
			}

			public override void Execute()
			{
				var id = dialog.SelectedNodes.OfType<OnlineOrdersVMNode>().First().OrderId.Value;
				dialog.TabParent.OpenTab<OrderDlg, int>(id, dialog);
			}
		}
	}
}
