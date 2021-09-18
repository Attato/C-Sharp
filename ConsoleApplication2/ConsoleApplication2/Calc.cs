using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calc();

            while (true)
            {
                var res = calc.Calculate(Console.ReadLine());
                Console.WriteLine(res);
            }
        }
    }
}