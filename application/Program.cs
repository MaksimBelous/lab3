using System;
using lab3.library;

namespace lab3.application
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(new Point(0, 0), new Point(6, 0), new Point(6, 6), new Point(0, 6));

            Console.WriteLine("Square area: " + square.CalculateArea());
            Console.WriteLine("Square perimeter: " + square.CalculatePerimeter());
            Console.WriteLine("Square point A: " + square.GetPoint(0));
            Console.WriteLine("Square point B: " + square.GetPoint(1));
            Console.WriteLine("Square point C: " + square.GetPoint(2));
            Console.WriteLine("Square point D: " + square.GetPoint(3));
        }
    }
}
