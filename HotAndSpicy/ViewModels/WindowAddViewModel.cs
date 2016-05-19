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
    class WindowAddViewModel : ViewModelBase
    {
        public Chili Model = new Chili(0, "Name", "sowingMonth", "severityLevel", "outdoorAfter", "true");
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

        public string name
        {
            get { return Model.name; }
            set
            {
                if (Model.name == value)
                    return;
                Model.name = value;
                OnPropertyChanged("name");
            }
        }

        public string sowingMonth
        {
            get { return Model.sowingMonth; }
            set
            {
                if (Model.sowingMonth == value)
                    return;
                Model.sowingMonth = value;
                OnPropertyChanged("sowingMonth");
            }
        }

        public string severityLevel
        {
            get { return Model.severityLevel; }
            set
            {
                if (Model.severityLevel == value)
                    return;
                Model.severityLevel = value;
                OnPropertyChanged("severityLevel");
            }
        }

        public string outdoorAfter
        {
            get { return Model.outdoorsAfter; }
            set
            {
                if (Model.outdoorsAfter == value)
                    return;
                Model.outdoorsAfter = value;
                OnPropertyChanged("outdoorAfter");
            }
        }

        public string hybridSeed
        {
            get { return Model.hybridSeed; }
            set
            {
                if (Model.hybridSeed == value)
                    return;
                Model.hybridSeed = value;
                OnPropertyChanged("hybridSeed");
            }
        }

        public string inUse
        {
            get { return Model.inUse; }
            set
            {
                if(Model.inUse == value)
                    return;
                Model.inUse = value;
                OnPropertyChanged("inUse");
            }
        }

        public Chili Chili { get; internal set; }
    }
}
