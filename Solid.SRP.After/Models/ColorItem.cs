using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace Solid.SingleResponsibility.Models
{
    public class ColorItem
    {
        public string Text { get; set; }
        public Color BackgroundColor { get; set; }
        public Color ForegroundColor { get; set; }
        public string Image { get; set; }
    }
}
