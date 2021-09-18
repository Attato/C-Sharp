using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication2
{
    public class Calc
    {
        delegate int Operaion(int a, int b);
        public int Calculate(string expression)
        {
            Operaion operation = null;
            int ?first = 0;
            int ?second = 0;
            for (var i = 0; i < expression.Length; i++)
            {
                var ch = expression[i];

                switch (ch)
                {
                    case '-': operation = Add; break;
                    case '+': operation = Sub; break;
                    default:
                        {
                            if (!char.IsDigit(ch))
                            {
                                throw new Exception("123");
                            }

                            var str = ch + "";

                            while(i + 1 < expression.Length && char.IsDigit(expression[i + 1]))
                            {
                                i++;
                                str += expression[i];
                            }

                            var tmp = int.Parse(str);

                            if (i > 0)
                            {
                                second = tmp;
                                break;
                            }
                            first = tmp;
                            break;                         
                        } 
                }
                if(operation != null &&
                    first.HasValue &&
                    second.HasValue)
                   
                {
                    first = operation(first.Value, second.Value);
                    operation = null;
                    second = null;
                }
            }
            return first.Value;
        }

        public int Add (int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
