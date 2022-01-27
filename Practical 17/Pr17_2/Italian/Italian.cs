using System;
using System.Collections.Generic;
using System.Text;

namespace Pr17_2.Italian
{
    public class Italian : IItalian
    {
        private readonly int _itTomatoes;
        private readonly int _itMushrooms;
        private readonly int _itCheese;
        private readonly int _itDough;

        public Italian(int itTomatoes, int itMushrooms, int itCheese, int itDough)
        {
            _itTomatoes = itTomatoes;
            _itMushrooms = itMushrooms;
            _itCheese = itCheese;
            _itDough = itDough;
        }

        public int itTomatoes
        {
            get { return _itTomatoes; }
        }
        public int itMushrooms
        {
            get { return _itMushrooms; }
        }
        public int itCheese
        {
            get { return _itCheese; }
        }
        public int itDough
        {
            get { return _itDough; }
        }
    }
}
