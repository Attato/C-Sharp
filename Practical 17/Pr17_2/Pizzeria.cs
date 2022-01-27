using System;
using Pr17_2.Decorator;

namespace Pr17_2
{
    public static class Pizzeria
    {
        public static void PrintUserInfo(IDecorator ingredient)
        {
            Console.WriteLine("Помидоры: \t {0} руб.", ingredient.Tomatoes);
            Console.WriteLine("Грибы: \t\t {0} руб.", ingredient.Mushrooms);
            Console.WriteLine("Сыр: \t\t {0} руб.", ingredient.Cheese);
            Console.WriteLine("Тесто: \t\t {0} руб.", ingredient.Dough);
            Console.WriteLine("Итог: \t\t {0} руб.", ingredient.Tomatoes + ingredient.Mushrooms + ingredient.Cheese + ingredient.Dough);
            Console.WriteLine("--- --- --- --- --- ---");
        }
    }
}

