using System;
using System.IO;

namespace Solid.ISP.After
{
    public interface IPrintMedium
    {
        void Print(string output);
        TextWriter OutputChannel { get; }
    }

    public class ConsolePrinter : IPrintMedium
    {
        public TextWriter OutputChannel
        {
            get { return Console.Out; }
        }

        public void Print(string output)
        {
            OutputChannel.WriteLine(output);
        }
    }

    public class FilePrinter : IPrintMedium
    {
        private TextWriter _outputChannel;

        public TextWriter OutputChannel
        {
            get { return _outputChannel; }
            set { _outputChannel = value;}
        }

        public void Print(string output)
        {
            using (OutputChannel = new StreamWriter(@"ISP_Output.txt"))
            {
                OutputChannel.WriteLine(output);
            }
        }
    }
}
