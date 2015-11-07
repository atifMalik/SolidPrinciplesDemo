using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.After
{
    public interface INotification
    {
        void SendNotification(string message);
    }

    public class EmailNotification : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending Email...");
            Console.WriteLine(message);
        }
    }

    public class TextNotification : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending Text...");
            Console.WriteLine(message);
        }
    }

    public class PostalNotification : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending Postal Mail...");
            Console.WriteLine(message);
        }
    }
}
