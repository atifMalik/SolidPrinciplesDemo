using Solid.SingleResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.SingleResponsibility.ViewModels
{
    public class ImageVM : BaseVM
    {
        private ColorItem _cuurentItem;
        public ColorItem CurrentItem
        {
            get { return _cuurentItem; }
            set
            {
                _cuurentItem = value;
                OnPropertyChanged("CurrentItem");
            }
        }
    }
}
