using HotAndSpicy.Controllers;
using HotAndSpicy.Framework;
using HotAndSpicy.Models;
using HotAndSpicy.ViewModels;
using HotAndSpicy.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotAndSpicy.Controllers
{
    class PlantAddWindowController
    {
        PlantAdd mView;


        public Plant AddPlant()
        {
            mView = new PlantAdd();
            PlantAddViewModel mViewModel = new PlantAddViewModel
            {
                Model = new Plant(),
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

        public Plant AddPlant(int id, int refId, DateTime sowingDate, DateTime outdoorsDate, string comment)
        {
            mView = new PlantAdd();
            PlantAddViewModel mViewModel = new PlantAddViewModel
            {
                Model = new Plant(id, refId, sowingDate, outdoorsDate, comment),
                OkCommand = new RelayCommand(ExecuteOkCommand),
                CancelCommand = new RelayCommand(ExecuteCancelCommand)
            };

            mViewModel.Model.id = id;

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

    }
}
