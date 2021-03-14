using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task2
{
    class Round
    {
        public int X;
        public int Y;
        public int Radius;
        
        public Round (int xValue, int yValue, int radiusValue)
        {
            X= xValue;
            Y = yValue;
            Radius = radiusValue;
        }
        public static double calculateArea(int xValue, int yValue, int radiusValue)
        {
            double area = Math.PI * radiusValue * radiusValue;
            Console.WriteLine("Area: {0}", area);
            return area;
        }

        public static double calculatePerimeter(int xValue, int yValue, int radiusValue)
        {

            double circumference = 2 * Math.PI * radiusValue;
            Console.WriteLine("Perimeter: {0}", circumference);
            return circumference;
        }
        
    }
}
