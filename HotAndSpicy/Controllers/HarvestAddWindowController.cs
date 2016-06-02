using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotAndSpicy.Framework;
using HotAndSpicy.Models;
using HotAndSpicy.ViewModels;
using HotAndSpicy.Views;

namespace HotAndSpicy.Controllers
{
    class HarvestAddWindowController
    {
        HarvestAdd mView;

        public Harvest AddHarvest(int amount, string date, int id)
        {
            mView = new HarvestAdd();
            HarvestAddViewModel mViewModel = new HarvestAddViewModel
            {
                Model = new Harvest(amount, date, id),
                OkCommand = new RelayCommand(ExecuteOkCommand),
                CancelCommand = new RelayCommand(ExecuteCancelCommand)
            };
            mView.DataContext = mViewModel;
            if (mView.ShowDialog() == true)
            {
                return mViewModel.Model;
            }
            else
            {
                return null;
            }
        }

        private void ExecuteCancelCommand(object obj)
        {
            mView.DialogResult = false;
            mView.Close();
        }

        private void ExecuteOkCommand(object obj)
        {
            mView.DialogResult = true;
            mView.Close();
        }
    }
}
