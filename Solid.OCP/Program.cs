using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Before.Orchestrator_Before.ShipProduct();

            //After.Orchestrator_Polymorphic.ShipProduct();
            Console.ReadLine();
        }
    }
}
