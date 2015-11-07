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
        }

        void ListViewVM_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "SelectedListBoxItem")
            {
                ListViewVM listViewVM = sender as ListViewVM;

                // Set the data context explicitly 
                MainWindow window = Application.Current.MainWindow as MainWindow;
                ImageVM vm = (ImageVM)window.imgBox.DataContext;

                vm.CurrentItem = listViewVM.SelectedListBoxItem;

            }
        }

        private void GetAllItems()
        {
            CurrentColorItems = new List<ColorItem>();
        }
    }
}
