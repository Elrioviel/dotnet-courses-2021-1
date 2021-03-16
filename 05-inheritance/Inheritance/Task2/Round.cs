using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Round
    {
        public int X;
        public int Y;
        public int Radius;

        public Round(int xValue, int yValue, int radiusValue)
        {
            X = xValue;
            Y = yValue;
            Radius = radiusValue;
        }
        public static double CalculateArea(int xValue, int yValue, int radiusValue)
        {
            double area = Math.PI * radiusValue * radiusValue;
            return area;
        }

        public static double CalculatePerimeter(int xValue, int yValue, int radiusValue)
        {
            double circumference = 2 * Math.PI * radiusValue;
            return circumference;
        }
    }
}
