using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotAndSpicy.Framework
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyname)
        {
            if (propertyname != null)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(propertyname));
                }
            }
        }
    }


}