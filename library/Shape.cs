using System;
using System.Collections.Generic;

namespace lab3.library
{
    public abstract class Shape
    {
        protected List<Point> coordinates = new List<Point>();

        protected Shape(List<Point> coordinates)
        {
            this.coordinates = coordinates;
        }

        protected int CalculateSide(int side)
        {
            int a = side;
            int b = side + 1;
            if (b == coordinates.Count)
            {
                b = 0;
            }

            return (int)Math.Sqrt(Math.Pow(coordinates[b].X - coordinates[a].X, 2) + Math.Pow(coordinates[b].Y - coordinates[a].Y, 2));
        }

    }
}
