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
    /// Interaction logic for DemoImage.xaml
    /// </summary>
    public partial class DemoImage : UserControl
    {
        public DemoImage()
        {
            ViewModel = new ImageVM();
            DataContext = ViewModel;

            InitializeComponent();
        }

        /// <summary>
        /// Gets the controller for this view 
        /// </summary>
        public ImageVM ViewModel { get; private set; }

    }
}
