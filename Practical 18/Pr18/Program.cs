using System;

namespace Pr18
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            printer.PowerOn();
            printer.PrintDocument();
            printer.AddPater(3);
            printer.PrintDocument();
            printer.PrintDocument();
            printer.PrintDocument();
            printer.PrintDocument();
            printer.PowerOff();
        }
    }
}
