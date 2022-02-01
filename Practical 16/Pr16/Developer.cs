using System;
using System.Collections.Generic;
using System.Text;

namespace Pr16
{
    abstract class Developer
    {
        public string Name { get; set; }
        public Developer(string n)
        {
            Name = n;
        }
        abstract public House Create();
    }

    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n) : base(n)
        {   }
        public override House Create()
        {
            return new PanelHouse();
        }
    }

    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n)
        { }
        public override House Create()
        {
            return new WoodHouse();
        }
    }

    class BrickDeveloper : Developer
    {
        public BrickDeveloper(string n) : base(n)
        { }
        public override House Create()
        {
            return new BrickHouse();
        }
    }
}
