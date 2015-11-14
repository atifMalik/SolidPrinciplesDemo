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
            
            // No need to Register, because Combobox does not need to be notified.
            //Mediator.Register(this, new string[] { Messages.Combobox_Color_Selected });
        }

        void ComboBoxVM_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "SelectedColor")
            {
                Mediator.NotifyColleagues(Messages.Combobox_Color_Selected, _selectedColor);

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
            // This method should never be called, because is not Registered with Mediator
            throw new NotImplementedException();
        }

    }
}
