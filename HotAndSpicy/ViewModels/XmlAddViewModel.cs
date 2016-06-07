using HotAndSpicy.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotAndSpicy.ViewModels
{
    class XmlAddViewModel : ViewModelBase
    {
        public ICommand CancelCommand { get; set; }
        public ICommand readXml { get; set; }


        private string _pfad;

        public string pfad
        {
            get { return _pfad; }
            set
            {
                if (value != _pfad)
                {
                    _pfad = value;
                    OnPropertyChanged("pfad");
                }
            }
        }
    }
}
