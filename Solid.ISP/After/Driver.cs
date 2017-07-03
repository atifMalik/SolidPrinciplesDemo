using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.After
{
    public static class Driver
    {
        public static void RunExample()
        {
            Product firstProduct = new Product() { Name = "Bose Portable Speakers", Price = 100 };
            Product secondProduct = new Product() { Name = "C# in Depth by Jon Skeet", Price = 35 };
            Product thirdProduct = new Product() { Name = "Head First Design Patterns by Eric Freeman", Price = 50 };
            var productsInOrder = new List<Product> { firstProduct, secondProduct, thirdProduct };

            Order placedOrder = new Order(productsInOrder, new DHL_ShippingStrategy(), new ConsolePrinter());
            placedOrder.Print();

            // Need to create another order with existing items and one additional item
            var newProducts = productsInOrder;
            newProducts.Add(new Product() { Name = "There's Something About Mary, DVD", Price = 12 });

            var newOrder = new OnlineOrder(newProducts, new USPS_ShippingStrategy(), new FilePrinter());

            // Getting Count of new order items; this is possible due to implementing IEnumerable<Product>
            Console.WriteLine("Second Order has {0} items.", newOrder.Count());
            newOrder.Print();

            var formattedAddress = string.Format("70 Blanchard Road{0}Burlington, MA 01803{0}", Environment.NewLine);
            Customer customer = new Customer(new ConsolePrinter()) { Name = "Atif Malik", OfficeAddress = formattedAddress };
            customer.Print();
        }
    }
}
