using HotAndSpicy.Framework;
using HotAndSpicy.Models;
using HotAndSpicy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotAndSpicy.Controllers
{
    class WindowAddController
    {
        WindowAdd mView;

        public Chili AddChili()
        {
            mView = new WindowAdd();
            WindowAddViewModel mViewModel = new WindowAddViewModel
            {
                Chili = new Chili(),
                OkCommand = new RelayCommand(ExecuteOkCommand),
                CancelCommand = new RelayCommand(ExecuteCancelCommand)
            };

            mView.DataContext = mViewModel;
            if(mView.ShowDialog() == true)
            {
                return mViewModel.Chili;
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
