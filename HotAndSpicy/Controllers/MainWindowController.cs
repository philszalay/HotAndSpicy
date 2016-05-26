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
        private MainWindow view;
        private MainWindowViewModel mViewModel;
        public ObservableCollection<Chili> chiliList { get; set; }
        private ObservableCollection<Plant> plantList { get; set; }
        private ObservableCollection<Harvest> harvestList { get; set; }

        public void Initialize()
        {
            view = new MainWindow();

            mViewModel = new MainWindowViewModel
            {
                Chilis = readChiliXML(),
                Plants = readPlantsXML(),
                Harvest = readHarvestXML(),

                HarvestPlant = new RelayCommand(HarvestPlant),
                DeleteHarvest = new RelayCommand(DeleteHarvest, CanDeleteHarvest),
                EditPlant = new RelayCommand(EditPlant),
                EditCommand = new RelayCommand(EditCommand),
                Einpflanzen = new RelayCommand(Einpflanzen),
                DeletePlant = new RelayCommand(DeletePlant, CanDeletePlant),
                AddCommand = new RelayCommand(AddCommandExecute),
                DeleteCommand = new RelayCommand(DeleteCommandExecute, DeletecommandCanExecute)
            };
            view.DataContext = mViewModel;
            view.ShowDialog();
        }

        private bool CanDeleteHarvest(object obj)
        {
            return true;
        }

        private void DeleteHarvest(object obj)
        {
            ///
            /// Delete also from XML file
            ///
            if (mViewModel.SelectedHarvest != null)
            {
                mViewModel.Harvest.Remove(mViewModel.SelectedHarvest);

                update();
            }
        }

        private void EditPlant(object obj)
        {
            var addedObject = new PlantAddWindowController().AddPlant(mViewModel.SelectedPlant.id, mViewModel.SelectedPlant.refId, mViewModel.SelectedPlant.sowingDate, mViewModel.SelectedPlant.outdoorsDate, mViewModel.SelectedPlant.comment);

            ///
            /// Add item to XML
            ///

            if (addedObject != null)
            {
                mViewModel.Plants.Remove(mViewModel.SelectedPlant);
                mViewModel.Plants.Add(addedObject);

                update();
            }
        }

        private void EditCommand(object obj)
        {
            var addedObject = new WindowAddController().AddChili(mViewModel.SelectedChili.id, mViewModel.SelectedChili.name, mViewModel.SelectedChili.sowingMonth, mViewModel.SelectedChili.severityLevel, mViewModel.SelectedChili.outdoorsAfter, mViewModel.SelectedChili.hybridSeed, mViewModel.SelectedChili.inUse);
            ///
            /// Add the Object in XML
            ///

            if (addedObject != null)
            {
                mViewModel.Chilis.Remove(mViewModel.SelectedChili);
                mViewModel.Chilis.Add(addedObject);

                update();
            }
        }

        private void HarvestPlant(object obj)
        {
            Harvest Model = new Harvest();
            Model.refId = mViewModel.SelectedPlant.refId;
            ///Model.ammount = 1;
            Model.date = DateTime.Now.ToString(); 
           
            mViewModel.Harvest.Add(Model);

            update();
        }

       
        private bool CanDeletePlant(object obj)
        {
            return true;
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
                    harvest.amount = Int32.Parse(reader.ReadInnerXml());

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

            update();
            
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
                mViewModel.Chilis.Remove(mViewModel.SelectedChili);

                update();
            }
            
        }

        private void AddCommandExecute(object obj)
        {
            var addedObject = new WindowAddController().AddChili();
            ///
            /// Add the Object in XML
            ///
            if (addedObject != null)
            {
                mViewModel.Chilis.Add(addedObject);

                update();
            }
        }

        /*public void AddPlant(object obj)
        {
            var addedObject = new WindowAddController().AddPlant();
            ///
            /// Add the Object in XML
            ///
            if(addedObject != null)
            { mViewModel.Plants.Add(addedObject); }
        }*/

        public void DeletePlant(object obj)
        {
            if(mViewModel.SelectedPlant != null)
            {
                mViewModel.Plants.Remove(mViewModel.SelectedPlant);

                update();
            }
        }

        /// <summary>
        /// Method for saving the data in XML and refreshing the tables.
        /// </summary>
        public void update()
        {
            ///
            /// Insert method for creating new XML file here.
            ///
            File.Delete("MainData.xml");
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.Encoding = System.Text.Encoding.UTF8;

            using (XmlWriter writer = XmlWriter.Create("MainData.xml", settings))
            {
                writer.WriteStartElement("Stock");

                foreach(Chili chili in chiliList)
                {
                    writer.WriteStartElement("ChiliModel");

                    writer.WriteStartElement("ID");
                    writer.WriteString(chili.id.ToString());
                    writer.WriteEndElement();

                    writer.WriteStartElement("Name");
                    writer.WriteString(chili.name);
                    writer.WriteEndElement();

                    writer.WriteStartElement("SowingMonth");
                    writer.WriteString(chili.sowingMonth);
                    writer.WriteEndElement();

                    writer.WriteStartElement("SeverityLevel");
                    writer.WriteString(chili.severityLevel);
                    writer.WriteEndElement();

                    writer.WriteStartElement("OutdoorsAfter");
                    writer.WriteString(chili.outdoorsAfter);
                    writer.WriteEndElement();

                    writer.WriteStartElement("HybridSeed");
                    writer.WriteString(chili.hybridSeed);
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                }

                /// end "Stock"
                writer.WriteEndElement();

                writer.WriteStartElement("RealPlants");

                foreach (Plant plant in plantList)
                {
                    writer.WriteStartElement("RealPlantModel");

                    writer.WriteStartElement("ID");
                    writer.WriteString(plant.id.ToString());
                    writer.WriteEndElement();

                    writer.WriteStartElement("RefID");
                    writer.WriteString(plant.refId.ToString());
                    writer.WriteEndElement();

                    writer.WriteStartElement("SowingDate");
                    writer.WriteString(plant.sowingDate);
                    writer.WriteEndElement();

                    writer.WriteStartElement("OutdoorsDate");
                    writer.WriteString(plant.outdoorsDate);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Comment");
                    writer.WriteString(plant.comment);
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();

                foreach (Harvest harvest in harvestList)
                {
                    writer.WriteStartElement("HarvestData");

                    writer.WriteStartElement("Date");
                    writer.WriteString(harvest.date);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Amount");
                    writer.WriteString(harvest.amount.ToString());
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                }

                writer.WriteEndDocument();

                writer.Close();
            }

            /// DAS GEHT SO NICHT!!
            view.Hide();
            Initialize();
        }
    }
}
