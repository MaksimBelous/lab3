using System;
using System.Collections.Generic;

namespace lab3.library
{
    public class Square : Shape
    {
        public Square(Point a, Point b, Point c, Point d) : base(CreateCoordinates(a, b, c, d))
        {
        }

        private static List<Point> CreateCoordinates(Point a, Point b, Point c, Point d)
        {
            return new List<Point> { a, b, c, d };
        }

        public Point GetPoint(int pointIndex)
        {
            return base.coordinates[pointIndex];
        }

        public int CalculateArea()
        {
            int a = this.CalculateSide(0);
            return a * a;
        }

        public int CalculatePerimeter()
        {
            int a = this.CalculateSide(0);
            return 4 * a;
        }
    }
}
