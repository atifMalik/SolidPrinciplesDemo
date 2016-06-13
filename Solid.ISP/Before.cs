using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.Before
{

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public void Ship(double totalCharged)
        {
            Console.WriteLine("Product {0} was shipped.", Name);
        }
    }

    public interface IOrder
    {
        List<Product> GetAllItems();
        int GetItemsCount();
        void ShipAllItems();
        void Print();
    }

    public class Order : IOrder
    {
        private List<Product> Products { get; set; }

        public Order(List<Product> orderItems)
        {
            Products = orderItems;
        }

        public List<Product> GetAllItems()
        {
            return Products;
        }

        public int GetItemsCount()
        {
            return Products.Count;
        }

        public void ShipAllItems()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Shipping Order, using {0}:", "Fedex");
            Console.ResetColor();
            foreach (var orderItem in Products)
            {
                var shipping = 0;   // no shipping cost involved this time. 
                var total = shipping + orderItem.Price;

                // Charge Customer the {total} amount
                // Not Implemented

                orderItem.Ship(total);
            }
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Printing Order. Items in the Order:", "Fedex");
            Console.ResetColor();

            foreach (var item in Products)
            {
                Console.WriteLine("{0}; price: {1},", item.Name, item.Price);
            }
        }
    }

    public static class Driver
    {
        public static void RunExample()
        {
            Product firstProduct = new Product() { Name = "Bose Portable Speakers", Price = 100 };
            Product secondProduct = new Product() { Name = "Being and Nothingness by Jean-Paul Sartre", Price = 35 };
            Product thirdProduct = new Product() { Name = "Head First Design Patterns by Eric Freeman", Price = 50 };

            var productsInOrder = new List<Product> { firstProduct, secondProduct, thirdProduct };

            Order placedOrder = new Order(productsInOrder);

            // Print details of order items
            placedOrder.Print();
            // Ship the items
            placedOrder.ShipAllItems();

            // Need to create another order with existing items and one additional item
            List<Product> newProducts = placedOrder.GetAllItems();
            newProducts.Add(new Product() { Name = "There's Something About Mary, DVD", Price = 12 });

            Order newOrder = new Order(newProducts);

            Console.WriteLine();
            // Print details of order items
            newOrder.Print();
            // Ship the items
            newOrder.ShipAllItems();
        }
    }
}
