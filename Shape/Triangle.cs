using System;

namespace Oop.Shape
{
    public class Triangle : Shape
    {
        private readonly int _bottom;
        private readonly int _height;

        public Triangle(int bottom, int height)
        {
            _bottom = bottom;
            _height = height;
        }

        public override double CaleArea()
        {
            var area = _bottom * _height / 2;
            return area;
        }

        public override string GetArea()
        {
            return "三角形";
        }

        public override void PrintArea()
        {
            Console.WriteLine($"圖形為{GetArea()},底:{_bottom},高:{_height}，面積為:{CaleArea()}");
        }
    }
}