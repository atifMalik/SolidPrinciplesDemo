using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP.Before
{
    public enum ShippingMethod
    {
        USPS = 0,
        FedEx,
        DHL,
        UPS,
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public void Ship(double totalCharged)
        {
            Console.WriteLine("Product {0} was shipped; customer was charged ${1}.", Name, totalCharged);
        }
    }



    /// <summary>
    /// Note: this class **IS NOT** closed for modification
    /// </summary>
    public class ProductShipper
    {
        public double CalculateShippingCost(ShippingMethod method)
        {
            double cost = 0;
            switch(method)
            {
                case ShippingMethod.USPS:
                    cost = 1.0 * 1;
                    break;
                case ShippingMethod.FedEx:
                    cost = 1.0 * 2;
                    break;
                case ShippingMethod.DHL:
                    cost = 1.0 * 3;
                    break;
                case ShippingMethod.UPS:
                    cost = 1.0 * 4;
                    break;
            }

            return cost;
        }

        public void ShipProduct(Product product, ShippingMethod method)
        {
            var shipping = CalculateShippingCost(method);
            var total = shipping + product.Price;

            // Charge Customer the {total} amount
            // Not Implemented

            product.Ship(total);
        }
    }

    public static class Driver
    {
        public static void ShipProduct()
        {
            var aProduct = new Product() { Name = "Amazon Fire", Price = 100 };
            var anotherProduct = new Product() { Name = "Apple TV", Price = 100 };

            ProductShipper shipper = new ProductShipper();
            shipper.ShipProduct(aProduct, ShippingMethod.DHL);
            shipper.ShipProduct(anotherProduct, ShippingMethod.FedEx);
        }
    }
}
