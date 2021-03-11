using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task2
{
    class Round
    {
        public int _xValue;
        public int _yValue;
        public int _radius;
        
        public Round (int _xValue, int _yValue, int _radius)
        {
            this._xValue = _xValue;
            this._yValue = _yValue;
            this._radius = _radius;
        }
        public static double getArea(int _xValue, int _yValue, int _radius)
        {
            double area = Math.PI * _radius * _radius;
            Console.WriteLine("Area: {0}", area);
            return area;
        }

        public static double getPerim(int _xValue, int _yValue, int _radius)
        {

            double circumference = 2 * Math.PI * _radius;
            Console.WriteLine("Perimeter: {0}", circumference);
            return circumference;
        }
        
    }
}
