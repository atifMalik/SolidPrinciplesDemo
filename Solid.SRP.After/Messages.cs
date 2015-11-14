using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.SingleResponsibility
{
    /// <summary>
    /// Defines a list of messages that the ViewModels use to communicate with each other
    /// </summary>
    public static class Messages
    {
        /// <summary>
        /// Message to notify that a color was selected in Combobox ViewModel
        /// </summary>
        public const string Combobox_Color_Selected = "Combobox_Color_Selected";

        /// <summary>
        /// Message to notify that a color was selected in ListView ViewModel
        /// </summary>
        public const string ListBox_Color_Selected = "ListBox_Color_Selected";

        /// <summary>
        /// Message to notify that an image was selected in Image ViewModel
        /// </summary>
        public const string Image_Selected = "Image_Selected";
    }
}
