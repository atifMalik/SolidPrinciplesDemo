using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP.After
{
    //public enum ShippingMethod
    //{
    //    USPS = 0,
    //    Fedex,
    //    DHL,
    //    UPS
    //}

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public void Ship(double totalCharged)
        {
            Console.WriteLine("Product {0} was shipped; customer was charged ${1}.", Name, totalCharged);
        }
    }

    #region Strategies

    /// <summary>
    /// This interface **IS OPEN** for Extension
    /// </summary>
    public interface IShippingStrategy
    {
        double CalculateShippingCost();
    }

    /// <summary>
    /// Example of Extension
    /// </summary>
    public class DHL_ShippingStrategy : IShippingStrategy
    {
        public double CalculateShippingCost()
        {
            return 1.0 * 3;
        }
    }

    /// <summary>
    /// Another example of Extension
    /// </summary>
    public class USPS_ShippingStrategy : IShippingStrategy
    {
        public double CalculateShippingCost()
        {
            return 1.0 * 1;
        }
    }

    #endregion


    /// <summary>
    /// Note, this class **IS** closed for modification
    /// </summary>
    public class ProductShipper
    {
        private IShippingStrategy _shippingStrategy;

        /// <summary>
        /// No default Constructor ensures that a Strategy object is always provided when constructing a ProductShipper
        /// </summary>
        /// <param name="shippingStrategy"></param>
        public ProductShipper(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        //public double CalculateShippingCost(ShippingMethod method)
        //{
        //    double cost = 0;
        //    switch(method)
        //    {
        //        case ShippingMethod.USPS:
        //            cost = 1.0 * 1;
        //            break;
        //        case ShippingMethod.Fedex:
        //            cost = 1.0 * 2;
        //            break;
        //        case ShippingMethod.DHL:
        //            cost = 1.0 * 3;
        //            break;
        //        case ShippingMethod.UPS:
        //            cost = 1.0 * 4;
        //            break;
        //    }
        //    return cost;
        //}

        public void ShipProduct(Product product)
        {
            // the following line makes it Polymorphic
            var shipping = _shippingStrategy.CalculateShippingCost();

            var total = shipping + product.Price;

            // Charge Customer the {total} amount
            // Not Implemented

            product.Ship(total);
        }
    }

    public static class Driver_Polymorphic
    {
        public static void ShipProduct()
        {
            var aProduct = new Product() { Name = "Amazon Fire", Price = 100 };
            var anotherProduct = new Product() { Name = "Apple TV", Price = 100 };

            ProductShipper shipper = new ProductShipper(new DHL_ShippingStrategy());
            shipper.ShipProduct(aProduct);

            shipper = new ProductShipper(new USPS_ShippingStrategy());
            shipper.ShipProduct(anotherProduct);
        }
    }
}
