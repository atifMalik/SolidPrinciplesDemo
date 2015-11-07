using System;

namespace Solid.ISP.After
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
}
