using System;
using Oop.Interface;

namespace Oop.Shape
{
    public abstract class Shape : IShape
    {
        public virtual double CaleArea()
        {
            double area = 0;
            return area;
        }

        public virtual string GetArea()
        {
            return "";
        }


        public virtual void PrintArea()
        {
            Console.WriteLine("This Area:");
        }
    }
}