using Solid.SingleResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Solid.SingleResponsibility.ViewModels
{
    public class ComboBoxVM : BaseVM
    {
        #region Properties
        List<ColorItem> _allColorItems;
        public List<ColorItem> AllColorItems
        {
            get { return _allColorItems; }
            set
            {
                _allColorItems = value;
                OnPropertyChanged("AllColorItems");
            }
        }

        private ColorItem _selectedColor;
        public ColorItem SelectedColor
        {
            get { return _selectedColor; }
            set
            {
                _selectedColor = value;
                OnPropertyChanged("SelectedColor");
            }
        } 
        #endregion


        public ComboBoxVM()
        {
            PropertyChanged += ComboBoxVM_PropertyChanged;
            GetAllItems();
            Mediator.Register(this, new string[] { "ItemSelected" });
        }

        void ComboBoxVM_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "SelectedColor")
            {
                Mediator.NotifyColleagues("ComboItemSelected", _selectedColor);

                //ComboBoxVM comboVM = sender as ComboBoxVM;
                //// Set the data context explicitly on the other window
                //MainWindow window = Application.Current.MainWindow as MainWindow;
                //ListViewVM vm = (ListViewVM)window.lstBox.DataContext;
                //List<ColorItem> list = vm.CurrentColorItems;
                //list.Add(comboVM.SelectedColor);
                //vm.CurrentColorItems = new List<ColorItem>(list);
            }
        }

        private void GetAllItems()
        {
            AllColorItems = Models.DemoItemService.GetAllItems();
        }

        /// <summary>
        /// Notification from the Mediator
        /// </summary>
        /// <param name="message">The message type</param>
        /// <param name="args">Arguments for the message</param>
        public override void MessageNotification(string message, object args)
        {
            switch (message)
            {
                //change the CurrentProduct to be the newly selected product
                case "AddColorItem":
                    AllColorItems.Add((ColorItem)args);
                    break;
            }
        }

    }
}
