using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Calc
    {
        delegate int Operaion(int? a);
        public int Calculate(string expression)
        {
            Operaion operation = null;
            int? first = null;       
            for (var i = 0; i < expression.Length; i++)
            {
                var ch = expression[i];

                switch (ch)
                {
                    case '*':
                        {
                            i++;
                            var tmp = Parse(ref i, expression);
                            if (operation != null)
                            {
                                second = tmp * second.Value;
                            }
                            else
                            {
                                first = tmp * first.Value;
                            }
                        }
                        break;
                    case '-': 
                        {
                            var inner = operation;
                            var s = first;
                            var tmp = Parse(ref i, expression);
                            operation = (int? a) =>
                            {
                                var s1 = operation != null 
                                ? operation(a)
                                :s.Value;
                            return Add(s1, tmp);
                            };
                        }
                    break;

                    case '+':
                        {         
                            var inner = operation;
                            var firstInner = first;
                            int? secondInner = Parse(ref i, expression);
                            operation = (int? a) =>
                            {
                                secondInner = a == null ? secondInner : a;
                                return opperation != null
                                ? operation(firstInner.Value + secondInner.Value)
                                : firstInner.Value + secondInner.Value;
                            };
                        }
                        break;
                    default:
                        {
                            var tmp = Parse(ref i, expression);
                            first = tmp;
                            break;   
                        }
                }
            }

            if (operation != null &&
                first.HasValue)
                {
                    first = operation(null);
                    operation = null;
                }

            return first.Value;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}