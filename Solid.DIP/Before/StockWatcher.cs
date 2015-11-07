using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Before
{
    public class StockWatcher
    {
        public void CompareStocks(char userInput)
        {
            string symbol = MockModel.RegisteredStockSymbols.ContainsKey(userInput) ?
                            MockModel.RegisteredStockSymbols[userInput] : 
                            "INVD";

            string message = string.Empty;

            if(symbol == "INVD")
            {
                message = "Invalid selection; try again!";
                NotifyCustomer(message);
                return;
            }

            var onlineService = new OnlineStockRepository();
            Stock onlineStock = onlineService.GetStockBySymbol(symbol);

            var databaseService = new DatabaseStockRepository();
            Stock databaseStock = databaseService.GetStockBySymbol(symbol);

            if (onlineStock.Price > databaseStock.Price)
                 message = string.Format("Current stock price for {0} is higher than what you paid.{1}", symbol, Environment.NewLine);
            else if (onlineStock.Price < databaseStock.Price)
                message = string.Format("Current stock price for {0} is lower than what you paid.{1}", symbol, Environment.NewLine);

            NotifyCustomer(message);
        }

        private void NotifyCustomer(string message)
        {
            if (MockModel.CurrentCustomer.NotificationMethod == CustomerNotificationPreference.Email)
                SendEmailToCustomer(message);
            else if (MockModel.CurrentCustomer.NotificationMethod == CustomerNotificationPreference.Text)
                SendTextToCustomer(message);
        }

        private void SendEmailToCustomer(string message)
        {
            Console.WriteLine("Sending Email...");
            Console.WriteLine(message);
        }

        private void SendTextToCustomer(string message)
        {
            Console.WriteLine("Sending Text...");
            Console.WriteLine(message);
        }
    }
}
