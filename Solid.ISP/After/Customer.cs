using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.After
{
    public class Customer : IPrinter
    {
        private IPrintMedium _printMethod;

        public string Name { get; set; }
        public string OfficeAddress { get; set; }
        
        public Customer(IPrintMedium printMethod)
        {
            _printMethod = printMethod;
        }

        public void Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Reusability Example: Printing Cusotmer's Info");
            sb.AppendLine(Name);
            sb.AppendLine(OfficeAddress);

            _printMethod.Print(sb.ToString());
        }
    }
}
