using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.After
{
    public interface IOrder
    {
        // Not needed
        //List<Product> GetAllItems();
        //int GetItemsCount();
        void ShipAllItems();
        //void Print();
    }

    /// <summary>
    /// Can (and should) be reused across other entities
    /// </summary>
    public interface IPrinter
    {
        void Print();
    }

    public class Order : IOrder, IEnumerable<Product>, IPrinter
    {
        private List<Product> Products { get; set; }
        private IShippingStrategy _shippingMethod;
        private IPrintMedium _printMethod;
        protected StringBuilder _sbPrintMessage;

        public Order(List<Product> orderItems, IShippingStrategy shippingMethod, IPrintMedium printMethod)
        {
            Products = orderItems;
            _shippingMethod = shippingMethod;
            _printMethod = printMethod;
            _sbPrintMessage = new StringBuilder();
        }

        #region IOrder Members
        public void ShipAllItems()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Products being shipped, using {0}:", _shippingMethod.Name);
            Console.ResetColor();
            foreach (var orderItem in Products)
            {
                var shipping = _shippingMethod.CalculateShippingCost();

                var total = shipping + orderItem.Price;

                // Charge Customer the {total} amount
                // Not Implemented

                orderItem.Ship(total);
            }
        }
        #endregion

        //public void PrintShippingDetail()
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("{0} was used as the Shipping Method; Items in the Order:", _shippingMethod.Name);
        //    Console.ResetColor();

        //    foreach (var item in Products)
        //    {
        //        Console.WriteLine("{0}; price: {1},", item.Name, item.Price);
        //    }
        //}

        // Not needed anymore, taken care of by IEnumerable<Product>
        //public List<Product> GetAllItems()
        //{
        //    return Products;
        //}

        //public int GetItemsCount()
        //{
        //    return Products.Count;
        //}

        #region IEnumerable Members
        public IEnumerator<Product> GetEnumerator()
        {
            return Products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Products.GetEnumerator();
        }

        public Product this[int index]
        {
            get
            {
                if (index < Products.Count)
                {
                    return Products[index];
                }
                else
                {
                    return null;
                }
            }

            set
            {
                if (index >= Products.Count)
                {
                    Products.Add(value);
                }
                else
                    Products[index] = value;
            }
        }
        #endregion

        public virtual void Print()
        {
            _sbPrintMessage.AppendFormat("{0} was used as the Shipping Method; There were {1} Items in the Order:{2}", _shippingMethod.Name, Products.Count, Environment.NewLine);

            foreach (var item in Products)
            {
                _sbPrintMessage.AppendFormat("{0}; price: {1},", item.Name, item.Price);
                _sbPrintMessage.AppendLine();
            }

            _printMethod.Print(_sbPrintMessage.ToString());
        }
    }
}
