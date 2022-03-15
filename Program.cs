using System;
using Oop.Shape;

namespace Oop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Excuteing.Excute();
        }

        private static class Excuteing
        {
            public static void Excute()
            {
                Console.Write("請輸入圖形:");
                var area = Console.ReadLine();
                switch (area?.ToLower())
                {
                    case "circle":
                        Console.Write("請輸入半徑:");
                        if (!double.TryParse(Console.ReadLine(), out var redis))
                            Console.WriteLine("請輸入正確之半徑格式!");
                        else
                            new Circle(redis).PrintArea();
                        break;
                    case "square":
                        Console.Write("請輸入邊:");
                        if (int.TryParse(Console.ReadLine(), out var width))
                            new Square(width).PrintArea();
                        else
                            Console.WriteLine("請輸入正確邊之格式!");
                        break;
                    case "triangle":
                        Console.Write("請輸入底:");
                        if (!int.TryParse(Console.ReadLine(), out var bottom))
                        {
                            Console.WriteLine("請輸入正確格式之底!");
                            break;
                        }

                        Console.Write("請輸入高:");
                        if (!int.TryParse(Console.ReadLine(), out var height))
                        {
                            Console.WriteLine("請輸入正確之高之格式!");
                            break;
                        }

                        new Triangle(bottom, height).PrintArea();
                        break;
                    default:
                        Console.WriteLine("圖形輸入錯誤!!");
                        break;
                }
            }
        }
    }
}