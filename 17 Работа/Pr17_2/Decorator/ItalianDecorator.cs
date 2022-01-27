using System;
using System.Collections.Generic;
using System.Text;
using Pr17_2.Italian;

namespace Pr17_2.Decorator
{
    class ItalianDecorator : IDecorator
    {
        private readonly IItalian _italian;
        public ItalianDecorator(IItalian italian)
        {
            _italian = italian;
        }
        public int Tomatoes {
            get { return _italian.itTomatoes; }
        }
        public int Mushrooms {
            get { return _italian.itMushrooms; }
        }
        public int Cheese {
            get { return _italian.itCheese; }
        }
        public int Dough {
            get { return _italian.itDough; }
        }
    }
}
