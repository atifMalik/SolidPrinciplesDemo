using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.After
{
    public interface IStockRepository
    {
        string Name { get; }
        Stock GetStockBySymbol(string symbol);
    }

    public class OnlineStockRepository : IStockRepository
    {
        public string Name
        {
            get { return "Online Stock"; }
        }

        public Stock GetStockBySymbol(string symbol)
        {
            return MockModel.GetStocksFromOnlineService().Where(f => f.Symbol == symbol).FirstOrDefault();
        }
    }

    public class DatabaseStockRepository : IStockRepository
    {
        public string Name
        {
            get { return "Database Stock"; }
        }

        public Stock GetStockBySymbol(string symbol)
        {
            return MockModel.GetStocksFromDatabase().Where(f => f.Symbol == symbol).FirstOrDefault();
        }
    }
}
