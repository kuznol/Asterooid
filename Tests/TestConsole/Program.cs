using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    static class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();

            printer.Print("Hello World!");

            printer = new PrefixPrinter(">>>>>");

            printer.Print("Hello World!");

            printer = new DateTimeLogPrinter();
            printer.Print("Hello World!");


            Console.ReadLine();
        }
    }

    class Printer
    {
        public Printer()
        {

        }

        public virtual void Print(string str)
        {
            Console.WriteLine(str);
        }
    }

    class PrefixPrinter : Printer
    {
        private string _Prefix;

        public PrefixPrinter(string Prefix)
        {
            _Prefix = Prefix;
        }
        //public PrefixPrinter(string Prefix) { _Prefix = Prefix; }

        public override void Print(string str)
        {
            //Console.WriteLine("{0}{1}", _Prefix, str);
            base.Print(_Prefix + str);
        }
    }

    class DateTimeLogPrinter : Printer
    {
        public override void Print(string str)
        {
            Console.Write(DateTime.Now);
            Console.Write(">>");
            base.Print(str);
        }
    }

    class FilePrinter : Printer
    {
        private string _FileName;

        public FilePrinter(string FileName) => _FileName = FileName;

        public override void Print(string str)
        {
            System.IO.File.AppendAllText(_FileName, str);

        }

    }
}
