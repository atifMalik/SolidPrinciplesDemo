using Solid.SingleResponsibility.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Solid.SingleResponsibility.Views
{
    /// <summary>
    /// Interaction logic for ColorComboBox.xaml
    /// </summary>
    public partial class ColorComboBox : UserControl
    {
        public ColorComboBox()
        {
            ViewModel = new ComboBoxVM();
            DataContext = ViewModel;
            InitializeComponent();
        }

        public ComboBoxVM ViewModel { get; private set; }
    }
}
