﻿using HotAndSpicy.Framework;
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

namespace HotAndSpicy.Controllers
{
    class WindowAddController
    {
        WindowAdd mView;

        public Plant AddPlant()
        {
            ///mView = new PlantAdd();
            PlantAddViewModel mViewModel = new PlantAddViewModel
            {
                Model = new Plant(),
                OkCommand = new RelayCommand(ExecuteOkCommand),
                CancelCommand = new RelayCommand(ExecuteCancelCommand)
            };
            mView.DataContext = mViewModel;
            if(mView.ShowDialog() == true)
            {
                return mViewModel.Model;
            } else
            {
                return null;
            }
        }
            
        

        public Chili AddChili()
        {
            mView = new WindowAdd();
            WindowAddViewModel mViewModel = new WindowAddViewModel
            {
                Model = new Chili(),
                OkCommand = new RelayCommand(ExecuteOkCommand),
                CancelCommand = new RelayCommand(ExecuteCancelCommand)
            };

            mView.DataContext = mViewModel;
            if(mView.ShowDialog() == true)
            {
                /// function for creating ID
                createID(mViewModel.Model);

                /// set inUse default value false
                mViewModel.Model.inUse = "false";

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

        public void createID(Chili Model)
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
            foreach (Chili elem in list){
                if(max < elem.id)
                {
                    max = elem.id;
                }
            }
            Model.id = max + 1;
        }
    }
}
