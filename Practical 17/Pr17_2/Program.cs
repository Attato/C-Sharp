using System;
using Pr17_2.Decorator;

namespace Pr17_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ItalianPizza = new Italian.Italian(25, 120, 100, 50);
            var BulgarianPizza = new Bulgarian.Bulgarian(45, 0, 120, 50);

            Console.WriteLine("Итальянская пицца");
            Pizzeria.PrintUserInfo(new ItalianDecorator(ItalianPizza));
            Console.WriteLine("Болгарская пицца");
            Pizzeria.PrintUserInfo(new BulgarianDecorator(BulgarianPizza));

            Console.Read();
        }
    }
}


