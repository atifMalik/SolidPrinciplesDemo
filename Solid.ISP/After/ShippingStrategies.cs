using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.After
{
    public interface IShippingStrategy
    {
        string Name { get; }
        double CalculateShippingCost();
    }

    public class DHL_ShippingStrategy : IShippingStrategy
    {
        public string Name
        {
            get { return "DHL"; }
        }

        public double CalculateShippingCost()
        {
            return 1.0 * 3;
        }
    }

    public class USPS_ShippingStrategy : IShippingStrategy
    {
        public string Name
        {
            get { return "USPS"; }
        }

        public double CalculateShippingCost()
        {
            return 1.0 * 1;
        }
    }

}
