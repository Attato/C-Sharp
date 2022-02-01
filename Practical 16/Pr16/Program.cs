using System;

namespace Pr16
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new PanelDeveloper("ООО ПанельСтрой");
            House house = dev.Create();

            dev = new WoodDeveloper("Частный Застройщик");
            House house2 = dev.Create();

            dev = new BrickDeveloper("ООО КирпичСтрой");
            House house3 = dev.Create();
            Console.ReadLine();
        }
    }
}
