using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Before
{
    public class OnlineStockRepository
    {
        public Stock GetStockBySymbol(string symbol)
        {
            return MockModel.GetStocksFromOnlineService().Where(f => f.Symbol == symbol).FirstOrDefault();
        }
    }

    public class DatabaseStockRepository
    {
        public Stock GetStockBySymbol(string symbol)
        {
            return MockModel.GetStocksFromDatabase().Where(f => f.Symbol == symbol).FirstOrDefault();
        }
    }
}
