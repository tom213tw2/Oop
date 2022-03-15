using System;

namespace Oop.Shape
{
    public class Circle : Shape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override string GetArea()
        {
            return "圓形";
        }

        public override double CaleArea()
        {
            double area = 0;
            area = Math.PI * Math.Pow(_radius, 2);
            return area;
        }

        public override void PrintArea()
        {
            Console.WriteLine($"圖形為:{GetArea()},半徑為:{_radius}，面積為:{CaleArea()}");
        }
    }
}