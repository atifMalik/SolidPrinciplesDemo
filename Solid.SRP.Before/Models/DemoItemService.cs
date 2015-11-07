using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace Solid.SingleResponsibility.Models
{
    public class DemoItemService
    {
        public static List<ColorItem> GetAllItems()
        {
            List<ColorItem> list = new List<ColorItem>()
            {
                new ColorItem() { Text = "Red", BackgroundColor = Colors.Red, ForegroundColor = Colors.White, Image = "../Images/Red.jpg" },
                new ColorItem() { Text = "Orange", BackgroundColor = Colors.Orange, ForegroundColor = Colors.Black, Image = "../Images/Orange.jpg" },
                new ColorItem() { Text = "Cyan", BackgroundColor = Colors.Cyan, ForegroundColor = Colors.Black, Image = "../Images/Cyan.jpg" },
                new ColorItem() { Text = "Green", BackgroundColor = Colors.Green, ForegroundColor = Colors.White, Image = "../Images/Green.jpg" },
                new ColorItem() { Text = "Blue", BackgroundColor = Colors.Blue, ForegroundColor = Colors.White, Image = "../Images/Blue.jpg" },
                new ColorItem() { Text = "Purple", BackgroundColor = Colors.Purple, ForegroundColor = Colors.White, Image = "../Images/Purple.jpg" },
                new ColorItem() { Text = "Yellow", BackgroundColor = Colors.Yellow, ForegroundColor = Colors.Black, Image = "../Images/Yellow.jpg" },
                new ColorItem() { Text = "White", BackgroundColor = Colors.White, ForegroundColor = Colors.Black, Image = "../Images/White.jpg" },
                new ColorItem() { Text = "Black", BackgroundColor = Colors.Black, ForegroundColor = Colors.White, Image = "../Images/Black.jpg" },
                new ColorItem() { Text = "Brown", BackgroundColor = Colors.Brown, ForegroundColor = Colors.White, Image = "../Images/Brown.jpg" },
            };

            return list;
        }

        public static ColorItem GetItemByName(string name)
        {
            return GetAllItems().Where(x => x.Text == name).FirstOrDefault();
        }
    }
}
