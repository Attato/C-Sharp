using System;
using System.Collections.Generic;
using System.Text;

namespace Pr16
{
    abstract class House
    {
    }

    class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом построен");
        }
    }

    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом построен");
        }
    }

    class BrickHouse : House
    {
        public BrickHouse()
        {
            Console.WriteLine("Кирпичный дом построен");
        }
    }
}
