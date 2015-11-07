using System;
using System.IO;

namespace Solid.ISP.After
{
    public interface IPrintMedium
    {
        void Print(string output);
    }

    public class ConsolePrinter : IPrintMedium
    {
        private TextWriter outputChannel = Console.Out;
        public void Print(string output)
        {
            outputChannel.WriteLine(output);
        }
    }

    public class FilePrinter : IPrintMedium
    {
        private StreamWriter outputChannel;

        public void Print(string output)
        {
            using (outputChannel = new StreamWriter(@"ISP_Output.txt"))
            {
                outputChannel.WriteLine(output);
            }
        }
    }
}
