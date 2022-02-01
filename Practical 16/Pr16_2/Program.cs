using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Pr16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle figure = new Circle(30, 50, 60);
            Circle clonedFigure = figure.DeepCopy() as Circle;
            figure.Point.X = 100;
            figure.GetInfo();
            clonedFigure.GetInfo();

            Console.Read();
        }
    }

    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }

    [Serializable]

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    [Serializable]

    class Circle : IFigure
    {
        int radius;
        
        public Point Point { get; set; }

        public Circle(int r, int x, int y)
        {
            radius = r;
            this.Point = new Point { X = x, Y = y };
        }

        public IFigure Clone()
        {
            return this.MemberwiseClone() as IFigure;
        }
        
        public object DeepCopy()
        {
            object figure = null;
            using (MemoryStream tempStream = new MemoryStream())
            {
                BinaryFormatter binFormatter = new BinaryFormatter(null,
                    new StreamingContext(StreamingContextStates.Clone));

                binFormatter.Serialize(tempStream, this);
                tempStream.Seek(0, SeekOrigin.Begin);

                figure = binFormatter.Deserialize(tempStream);
            }
            return figure;
        }

        public void GetInfo()
        {
            Console.WriteLine("Круг радиусом {0}", radius);
        }
    }
}
