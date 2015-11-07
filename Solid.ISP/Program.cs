using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Before.Orchestrator_Before.RunExample();

            After.Orchestrator_After.RunExample();
            Console.ReadLine();
        }
    }
}
