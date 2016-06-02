using HotAndSpicy.Framework;
using HotAndSpicy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotAndSpicy.ViewModels
{
    class HarvestAddViewModel : ViewModelBase
    {
        public Harvest Model { get; set; }
        public ICommand OkCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public int getrefId
        {
            get { return Model.refId; }
            set
            {
                if (Model.refId == value)
                    return;
                Model.refId = value;
                OnPropertyChanged("RefID");
            }
        }

        public int getamount
        {
            get { return Model.amount; }
            set
            {
                if (Model.amount == value)
                    return;
                Model.amount = value;
                OnPropertyChanged("amount");
            }
        }

        public string getdate
        {
            get { return Model.date; }
            set
            {
                if (Model.date == value)
                    return;
                Model.date = value;
                OnPropertyChanged("date");
            }
        }

    }
}
