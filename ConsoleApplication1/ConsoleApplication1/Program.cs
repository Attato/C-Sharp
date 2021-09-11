using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
        public class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Введите число: ");
                int number = int.Parse(Console.ReadLine());
                int remineder, sum = 0;
                int temp = number;
                while (number > 0)
                {
                    //Get the remainder by dividing the number with 10  
                    remineder = number % 10;
                    //multiply the sum with 10 and then add the remainder
                    sum = (sum * 10) + remineder;
                    //Get the quotient by dividing the number with 10 
                    number = number / 10;
                }
                if (temp == sum)
                {
                    Console.WriteLine($"Число {temp} это Палиндром.");
                }
                else
                {
                    Console.WriteLine($"Число {temp} это не Палиндром");
                }
                Console.ReadKey();
            }
        }
}



