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
    public class ListViewVM : BaseVM
    {
        #region Properties
        List<ColorItem> _currentColorItems;
        public List<ColorItem> CurrentColorItems
        {
            get { return _currentColorItems; }
            set
            {
                _currentColorItems = value;
                OnPropertyChanged("CurrentColorItems");
            }
        }

        private ColorItem _currentListViewSelectedItem;
        public ColorItem SelectedListBoxItem
        {
            get { return _currentListViewSelectedItem; }
            set
            {
                _currentListViewSelectedItem = value;
                OnPropertyChanged("SelectedListBoxItem");
            }
        } 
        #endregion

        public ListViewVM()
        {
            PropertyChanged += ListViewVM_PropertyChanged;
            GetAllItems();
            Mediator.Register(this, new string[] { "ComboItemSelected" });
        }

        void ListViewVM_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "SelectedListBoxItem")
            {
                Mediator.NotifyColleagues("ListBoxItemSelected", _currentListViewSelectedItem);

                //ListViewVM listViewVM = sender as ListViewVM;
                //// Set the data context explicitly 
                //MainWindow window = Application.Current.MainWindow as MainWindow;
                //ImageVM vm = (ImageVM)window.imgBox.DataContext;
                //vm.CurrentItem = listViewVM.SelectedListBoxItem;
            }
        }

        private void GetAllItems()
        {
            CurrentColorItems = new List<ColorItem>();
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
                case "ComboItemSelected":
                    List<ColorItem> tempItems = CurrentColorItems;
                    tempItems.Add(args as ColorItem);
                    CurrentColorItems = new List<ColorItem>(tempItems);
                    break;
            }
        }

    }
}
