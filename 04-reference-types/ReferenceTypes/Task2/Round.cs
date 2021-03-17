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
        public double CalculateArea()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }

        public double CalculatePerimeter()
        {
            double circumference = 2 * Math.PI * Radius;
            return circumference;
        }
        
    }
}
