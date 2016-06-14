using Solid.SingleResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.SingleResponsibility.ViewModels
{
    public class ImageVM : BaseVM
    {
        private ColorItem _currentItem;
        public ColorItem CurrentItem
        {
            get { return _currentItem; }
            set
            {
                _currentItem = value;
                OnPropertyChanged("CurrentItem");
            }
        }

        public ImageVM()
        {
            Mediator.Register(this, new string[] { Messages.ListBox_Color_Selected });
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
                // Change the Image to correspond with Selected Color
                case Messages.ListBox_Color_Selected:
                   CurrentItem = (ColorItem)args;
                    break;
            }
        }
    }
}
