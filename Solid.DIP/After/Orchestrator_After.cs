using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.After
{
    public static class Orchestrator_After
    {
        public static void RunExample()
        {
            Console.WriteLine("Select a Company to lookup stocks.{0}(M for Microsoft, G for Google, A for Apple):", Environment.NewLine);

            ConsoleKeyInfo pressed;

            do
            {
                pressed = Console.ReadKey();
                Console.WriteLine();
                if (pressed.Key == ConsoleKey.Escape) break;

                StockMessageFactory messageFactory = new StockMessageFactory(new DatabaseStockRepository(), new OnlineStockRepository(), new StockComparer(), pressed.KeyChar);
                StockManager manager = new StockManager(messageFactory, new PostalNotification());

                manager.NotifyCustomer();

            } while (pressed.Key != ConsoleKey.Escape);
        }
    }
}
