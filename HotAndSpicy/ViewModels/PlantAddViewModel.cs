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
    class PlantAddViewModel : ViewModelBase
    {
        public Plant Model { get; set; }
        public ICommand OkCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public int id
        {
            get { return Model.id; }
            set
            {
                if (Model.id == value)
                    return;
                Model.id = value;
                OnPropertyChanged("id");
            }
        }

        public int refId
        {
            get { return Model.refId; }
            set
            {
                if (Model.refId == value)
                    return;
                Model.refId = value;
                OnPropertyChanged("refId");
            }
        }

        public DateTime sowingDate
        {
            get { return Model.sowingDate; }
            set
            {
                if (Model.sowingDate == value)
                    return;
                Model.sowingDate = value;
                OnPropertyChanged("sowingDate");
            }
        }

        public DateTime outdoorsDate
        {
            get { return Model.outdoorsDate; }
            set
            {
                if (Model.outdoorsDate == value)
                    return;
                Model.outdoorsDate = value;
                OnPropertyChanged("outdoorsDate");
            }
        }

        public string comment
        {
            get { return Model.comment; }
            set
            {
                if (Model.comment == value)
                    return;
                Model.comment = value;
                OnPropertyChanged("comment");
            }
        }

    }
}
