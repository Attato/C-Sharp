using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication2
{
    public class Calc
    {
        public int Calculate(string expression)
        {
            int first = 0;
            int second = 0;
            for (var i = 0; i < expression.Length; i++)
            {
                var ch = expression[i];

                switch (ch)
                {
                    case '-' throw null;
                    case '+' throw null;
                    default:
                        {
                            if (!char.IsDigit(ch))
                            {
                                throw new Exception("123");
                            }

                            var tmp = int.Parse(ch + "");

                            if (i > 0)
                            {
                                second = tmp;
                                break;
                            }
                            first = tmp;
                            break;                         
                        } 
                }
            }
        }

        public int Add (int a, int b)
        {

        }

        public int Sub(int a, int b)
        {

        }
    }
}
