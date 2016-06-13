using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Before
{
    public static class Driver
    {
        public static void RunExample()
        {
            Console.WriteLine("Select a Company to lookup stocks.{0}(M for Microsoft, G for Google, A for Apple):", Environment.NewLine);

            ConsoleKeyInfo pressed;
            do
            {
                pressed = Console.ReadKey();
                if (pressed.Key == ConsoleKey.Escape) break;

                StockWatcher watcher = new StockWatcher();
                Console.WriteLine(Environment.NewLine);
                watcher.CompareStocks(pressed.KeyChar);

            } while (pressed.Key != ConsoleKey.Escape);
        }
    }
}
