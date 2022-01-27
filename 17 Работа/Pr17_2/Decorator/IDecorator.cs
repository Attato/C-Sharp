using System;
using System.Collections.Generic;
using System.Text;

namespace Pr17_2.Decorator
{
    public interface IDecorator
    {
        int Tomatoes { get; }
        int Mushrooms { get; }
        int Cheese { get; }
        int Dough { get; }
    }
}
