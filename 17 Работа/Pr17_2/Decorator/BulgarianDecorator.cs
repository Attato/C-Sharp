using System;
using System.Collections.Generic;
using System.Text;
using Pr17_2.Bulgarian;

namespace Pr17_2.Decorator
{
    class BulgarianDecorator : IDecorator
    {
        private readonly IBulgarian _bulgarian;
        public BulgarianDecorator(IBulgarian bulgarian)
        {
            _bulgarian = bulgarian;
        }
        public int Tomatoes
        {
            get { return _bulgarian.buTomatoes; }
        }
        public int Mushrooms
        {
            get { return _bulgarian.buMushrooms; }
        }
        public int Cheese
        {
            get { return _bulgarian.buCheese; }
        }
        public int Dough
        {
            get { return _bulgarian.buDough; }
        }
    }
}
