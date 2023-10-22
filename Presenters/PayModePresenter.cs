using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource PayModeBindingSource;
        private IEnumerable<PayModeModel> PayModeList;


        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            this.PayModeBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectedPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectedPayMode;
            this.view.SaveEvent += SavePaymode;
            this.view.CancelEvent += CancelAction;

            this.view.setpayModeListBildingsource(PayModeBindingSource);

            loadAllPayModeList();

            this.view.show();
        }

        private void loadAllPayModeList()
        {
            PayModeList = repository.GetAll();
            PayModeBindingSource.DataSource = PayModeList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SavePaymode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedPayModeToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
           bool emptyValue = String.IsNullOrWhiteSpace(this.view.searchValue);
            if (emptyValue == false)
            {
                PayModeList = repository.GetByValue(this.view.searchValue);
            }
            else
            {
                PayModeList = repository.GetAll();
            }
            PayModeBindingSource.DataSource = PayModeList;
        }
    }
}
