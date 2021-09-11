using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static bool Palindrom(string s)
        {
            for (int i = 1, j = s.Length - 1; i < j; i++, j--)
                if (s[i] != s[j])
                    return false;
            return true;
        }

        static void Main()
        {
            string s;
            Console.Write("Введите строку: ");
            s = Console.ReadLine();
            if (Palindrom(s))
                Console.WriteLine("Эта строка - не Палиндром");
            else Console.WriteLine("Эта строка - Палиндром");
            Console.ReadLine();
        }
    }
}
