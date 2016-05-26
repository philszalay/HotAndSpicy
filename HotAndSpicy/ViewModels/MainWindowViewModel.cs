using HotAndSpicy.Framework;
using HotAndSpicy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotAndSpicy.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {

        private ObservableCollection<Chili> _Chilis;
        private Chili _SelectedChili;
        private ObservableCollection<Harvest> _Harvest;
        private Harvest _SelectedHarvest;
        private ObservableCollection<Plant> _Plants;
        private Plant _SelectedPlant;
        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand Einpflanzen { get; set; }
        public ICommand DeletePlant { get; internal set; }
        public ICommand HarvestPlant { get; internal set; }
        public ICommand EditPlant { get; internal set; }
        public ICommand EditCommand { get; internal set; }
        public ICommand DeleteHarvest { get; internal set; }



        public ObservableCollection<Chili> Chilis
        {
            get { return _Chilis; }
            set
            {
                if (_Chilis == value)
                    return;
                _Chilis = value;
                OnPropertyChanged("Chilis");
            }
        }

        public Chili SelectedChili
        {
            get { return _SelectedChili; }
            set
            {
                if (_SelectedChili == value)
                    return;
                _SelectedChili = value;
                OnPropertyChanged("Chilis");
            }
        }

        public ObservableCollection<Harvest> Harvest
        {
            get { return _Harvest; }
            set
            {
                if (_Harvest == value)
                    return;
                _Harvest = value;
                OnPropertyChanged("Harvest");
            }
        }

        public Harvest SelectedHarvest
        {
            get { return _SelectedHarvest; }
            set
            {
                if (_SelectedHarvest == value)
                    return;
                _SelectedHarvest = value;
                OnPropertyChanged("Harvest");
            }
        }

        public ObservableCollection<Plant> Plants
        {
            get { return _Plants; }
            set
            {
                if (_Plants == value)
                    return;
                _Plants = value;
                OnPropertyChanged("Plants");
            }
        }

        public Plant SelectedPlant
        {
            get { return _SelectedPlant; }
            set
            {
                if (_SelectedPlant == value)
                    return;
                _SelectedPlant = value;
                OnPropertyChanged("Plants");
            }
        }

    }
}
