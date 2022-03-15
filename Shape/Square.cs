using System;

namespace Oop.Shape
{
    public class Square : Shape
    {
        private readonly int _width;

        public Square(int width)
        {
            _width = width;
        }

        public override double CaleArea()
        {
            var area = Math.Pow(_width, 2);
            return area;
        }

        public override string GetArea()
        {
            return "正方形";
        }

        public override void PrintArea()
        {
            Console.WriteLine($"圖形為:{GetArea()},長為:{_width}，面積為:{CaleArea()}");
        }
    }
}