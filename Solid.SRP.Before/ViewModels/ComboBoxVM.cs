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
        }

        void ComboBoxVM_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "SelectedColor")
            {
                ComboBoxVM comboVM = sender as ComboBoxVM;

                // Set the data context explicitly on the other window
                MainWindow window = Application.Current.MainWindow as MainWindow;
                ListViewVM vm = (ListViewVM)window.lstBox.DataContext;
                List<ColorItem> list = vm.CurrentColorItems;
                list.Add(comboVM.SelectedColor);

                vm.CurrentColorItems = new List<ColorItem>(list);

            }
        }

        private void GetAllItems()
        {
            AllColorItems = Models.DemoItemService.GetAllItems();
        }

    }
}
