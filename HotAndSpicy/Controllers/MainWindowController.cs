using HotAndSpicy.Framework;
using HotAndSpicy.Models;
using HotAndSpicy.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Globalization;

namespace HotAndSpicy.Controllers
{
    class MainWindowController
    {
        private MainWindowViewModel mViewModel;
        public ObservableCollection<Chili> chiliList { get; set; }
        private ObservableCollection<Plant> plantList;
        private ObservableCollection<Harvest> harvestList;

        public void Initialize()
        {
            var view = new MainWindow();

            mViewModel = new MainWindowViewModel
            {
                Chilis = readChiliXML(),
                Plants = readPlantsXML(),
                Harvest = readHarvestXML(),
                AddCommand = new RelayCommand(AddCommandExecute),
                DeleteCommand = new RelayCommand(DeleteCommandExecute, DeletecommandCanExecute)
            };
            view.DataContext = mViewModel;
            view.ShowDialog();
        }


        /// <summary>
        /// Reads data out of XML file, creates the harvest objects. Make collection of them.
        /// </summary>
        /// <returns></returns>
        private ObservableCollection<Harvest> readHarvestXML()
        {
            harvestList = new ObservableCollection<Harvest>();
            string xmlString = System.IO.File.ReadAllText("MainData.xml");
            XmlReader reader = XmlReader.Create(new StringReader(xmlString));

            while (reader.Read())
            {
                if(reader.Name == "RealPlantModel" && reader.NodeType == XmlNodeType.Element)
                {
                    Harvest harvest = new Harvest();

                    reader.ReadToFollowing("RefID");
                    harvest.refId = Int32.Parse(reader.ReadInnerXml());

                    reader.ReadToFollowing("Date");
                    harvest.date = reader.ReadInnerXml();

                    reader.ReadToFollowing("Amount");
                    harvest.ammount = Int32.Parse(reader.ReadInnerXml());

                    harvestList.Add(harvest);
                }
            }
            return harvestList;
        }


        /// <summary>
        /// Reads dada out of XML file, creates the plant objects. Make collection of them.
        /// </summary>
        /// <returns></returns>
        private ObservableCollection<Plant> readPlantsXML()
        {
            plantList = new ObservableCollection<Plant>();
            string xmlString = System.IO.File.ReadAllText("MainData.xml");
            XmlReader reader = XmlReader.Create(new StringReader(xmlString));

            while (reader.Read())
            {
                if (reader.Name == "RealPlantModel" && reader.NodeType == XmlNodeType.Element)
                {
                    Plant plant = new Plant();
                    reader.ReadToFollowing("ID");
                    plant.id = Int32.Parse(reader.ReadInnerXml());

                    reader.ReadToFollowing("RefID");
                    plant.refId = Int32.Parse(reader.ReadInnerXml());

                    /// Sets "inUse" bool of the current plant to true
                    var used = chiliList.Where(x => x.id == plant.refId);

                    foreach(Chili chili in used)
                    {
                        chili.inUse = "true";
                    }   

                    reader.ReadToFollowing("SowingDate");
                    plant.sowingDate = reader.ReadInnerXml();

                    reader.ReadToFollowing("OutdoorsDate");
                    plant.outdoorsDate = reader.ReadInnerXml();

                    reader.ReadToFollowing("Comment");
                    plant.comment = reader.ReadInnerXml();

                    plantList.Add(plant);
                }
            }
            return plantList;          
        }


        /// <summary>
        /// Reads data out of XML file, creates the chili objects. Make collection of them.
        /// </summary>
        /// <returns></returns>
        private ObservableCollection<Chili> readChiliXML()
        {
            chiliList = new ObservableCollection<Chili>();
            string xmlString = System.IO.File.ReadAllText("MainData.xml");
            XmlReader reader = XmlReader.Create(new StringReader(xmlString));


            while(reader.Read()){
                if(reader.Name == "ChiliModel" && reader.NodeType == XmlNodeType.Element)
                {
                    Chili chili = new Chili();
                    reader.ReadToFollowing("ID");
                    chili.id = Int32.Parse(reader.ReadInnerXml());

                    reader.ReadToFollowing("Name");
                    chili.name = reader.ReadInnerXml();

                    reader.ReadToFollowing("SowingMonth");
                    chili.sowingMonth = reader.ReadInnerXml();

                    reader.ReadToFollowing("SeverityLevel");
                    chili.severityLevel = reader.ReadInnerXml();

                    reader.ReadToFollowing("OutdoorsAfter");
                    chili.outdoorsAfter = reader.ReadInnerXml();

                    reader.ReadToFollowing("HybridSeed");
                    chili.hybridSeed = reader.ReadInnerXml();

                    chili.inUse = "false";


                    chiliList.Add(chili);
                }
            }
            return chiliList;
        }

        
        public void Einpflanzen(object obj)
        {

            Plant Model = new Plant();
            createID(Model);
            Model.refId = mViewModel.SelectedChili.id;
            Model.sowingDate = "";
            Model.outdoorsDate = "";
            Model.comment = "";
            mViewModel.Plants.Add(Model);
            
        }

        public void createID(Plant Model)
        {
            ObservableCollection<Chili> list = new ObservableCollection<Chili>();
            string xmlString = System.IO.File.ReadAllText("MainData.xml");
            XmlReader reader = XmlReader.Create(new StringReader(xmlString));


            while (reader.Read())
            {
                if (reader.Name == "ChiliModel" && reader.NodeType == XmlNodeType.Element)
                {
                    Chili chili = new Chili();
                    reader.ReadToFollowing("ID");
                    chili.id = Int32.Parse(reader.ReadInnerXml());

                    list.Add(chili);
                }
            }

            int max = 0;
            foreach (Chili elem in list)
            {
                if (max < elem.id)
                {
                    max = elem.id;
                }
            }
            Model.id = max + 1;
        }


        private bool DeletecommandCanExecute(object obj)
        {
            return (mViewModel.SelectedChili != null && mViewModel.SelectedChili.inUse != "true");
        }

        private void DeleteCommandExecute(object obj)
        {
            if (mViewModel.SelectedChili != null && mViewModel.SelectedChili.inUse != "true")
            {
                string xmlString = System.IO.File.ReadAllText("MainData.xml");
                XmlReader reader = XmlReader.Create(new StringReader(xmlString));
                while (reader.Read())
                {
                    if (reader.Name == "ChiliModel" && reader.NodeType == XmlNodeType.Element)
                    {
                        ///
                        /// Delete the Object in XML
                        ///
                    }

                    mViewModel.Chilis.Remove(mViewModel.SelectedChili);
                }
            }
        }

        private void AddCommandExecute(object obj)
        {
            var addedObject = new WindowAddController().AddChili();
            ///
            /// Add the Object in XML
            ///
            if (addedObject != null)
            { mViewModel.Chilis.Add(addedObject); }
        }

        public void AddPlant(object obj)
        {
            var addedObject = new WindowAddController().AddPlant();
            ///
            /// Add the Object in XML
            ///
            if(addedObject != null)
            { mViewModel.Plants.Add(addedObject); }
        }

        public void DeletePlant(object obj)
        {
            if(mViewModel.SelectedPlant != null)
            {
                mViewModel.Plants.Remove(mViewModel.SelectedPlant);
            }
        }
    }
}
