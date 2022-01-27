using System;
using System.Collections.Generic;
using System.Text;

namespace Pr17_2.Bulgarian
{
    public class Bulgarian : IBulgarian
    {
        private readonly int _buTomatoes;
        private readonly int _buMushrooms;
        private readonly int _buCheese;
        private readonly int _buDough;

        public Bulgarian(int buTomatoes, int buMushrooms, int buCheese, int buDough)
        {
            _buTomatoes = buTomatoes;
            _buMushrooms = buMushrooms;
            _buCheese = buCheese;
            _buDough = buDough;
        }

        public int buTomatoes
        {
            get { return _buTomatoes; }
        }
        public int buMushrooms
        {
            get { return _buMushrooms; }
        }
        public int buCheese
        {
            get { return _buCheese; }
        }
        public int buDough
        {
            get { return _buDough; }
        }
    }
}
