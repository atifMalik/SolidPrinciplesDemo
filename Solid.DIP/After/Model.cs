using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.After
{
    public class Stock
    {
        public decimal Price { get; set; }
        public string Symbol { get; set; }
    }

    public class StockComparer : IComparer<Stock>
    {
        public int Compare(Stock x, Stock y)
        {
            int result = x.Price.CompareTo(y.Price);
            return result;
        }
    }

    

    public class Customer
    {
        public string Name { get; set; }
        public CustomerNotificationPreference NotificationMethod { get; set; }
    }

    public enum CustomerNotificationPreference
    {
        Email = 0,
        Text
    }

    public static class MockModel
    {
        private static Dictionary<char, string> _stockSymbolLookup;
        public static Dictionary<char, string> RegisteredStockSymbols
        {
            get
            {
                if (_stockSymbolLookup == null)
                {
                    _stockSymbolLookup = new Dictionary<char, string>();
                    _stockSymbolLookup.Add('M', "MSFT");
                    _stockSymbolLookup.Add('A', "APPL");
                    _stockSymbolLookup.Add('G', "GOOG");
                }
                return _stockSymbolLookup;
            }
        }

        private static Customer _currentCustomer;
        public static Customer CurrentCustomer
        {
            get
            {
                if (_currentCustomer == null)
                {
                    _currentCustomer = new Customer() { Name = "Atif Malik", NotificationMethod = CustomerNotificationPreference.Email };
                }
                return _currentCustomer;
            }
        }

        public static List<Stock> GetStocksFromOnlineService()
        {
            var stocks = new List<Stock>
            {
                new Stock { Symbol = "MSFT", Price = 30.31m },
                new Stock { Symbol = "APPL", Price = 578.18m },
                new Stock { Symbol = "GOOG", Price = 570.30m }
            };

            return stocks;
        }

        public static List<Stock> GetStocksFromDatabase()
        {
            var stocks = new List<Stock>
            {
                new Stock { Symbol = "MSFT", Price = 530.31m },
                new Stock { Symbol = "APPL", Price = 457.18m },
                new Stock { Symbol = "GOOG", Price = 378.30m }
            };

            return stocks;
        }
    }
}
