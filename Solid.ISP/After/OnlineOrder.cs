using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.After
{
    public class OnlineOrder : Order
    {
        public OnlineOrder(List<Product> orderItems, IShippingStrategy shippingMethod, IPrintMedium printMethod) :
            base(orderItems, shippingMethod, printMethod)
        {

        }

        public override void Print()
        {
            // Just adding one more line to highlight that this is an "Online Order"
            _sbPrintMessage.AppendFormat("This is an **Online Order**{0}", Environment.NewLine);
            base.Print();
        }
    }
}
