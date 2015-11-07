using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.After
{
    public abstract class MessageFactoryBase
    {
        public abstract string GetMessageForUser();
    }

    public class StockMessageFactory : MessageFactoryBase
    {
        private IStockRepository _repoA;
        private IStockRepository _repoB;
        private IComparer<Stock> _comparer;
        private char _userInput;

        public string Message { get; private set; }

        public StockMessageFactory(IStockRepository repoA, IStockRepository repoB, IComparer<Stock> comparer, char userInput)
        {
            _repoA = repoA;
            _repoB = repoB;
            _comparer = comparer;
            _userInput = userInput;
        }

        public override string GetMessageForUser()
        {
            string symbol = MockModel.RegisteredStockSymbols.ContainsKey(_userInput) ?
                            MockModel.RegisteredStockSymbols[_userInput] :
                            "INVD";

            if (symbol == "INVD")
            {
                Message = "Invalid selection; try again!";
                return Message;
            }

            var stockA = _repoA.GetStockBySymbol(symbol);
            var stockB = _repoB.GetStockBySymbol(symbol);

            if (_comparer.Compare(stockA, stockB) > 0)
                Message = string.Concat(_repoA.Name, string.Format(" price for {0} is higher than ", stockA.Symbol), _repoB.Name, " price.", Environment.NewLine);
            else
                Message = string.Concat(_repoB.Name, string.Format(" price for {0} is higher than ", stockB.Symbol), _repoA.Name, " price.", Environment.NewLine);

            return Message;
        }
    }
}
