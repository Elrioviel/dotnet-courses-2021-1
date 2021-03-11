using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task3
{
    class Triangle
    {
        public int _A;
        public int _B;
        public int _C;

        public Triangle(int _A, int _B, int _C)
        {
            this._A = _A;
            this._B = _B;
            this._C = _C;

        }
        public static int getPerimeter(int _A, int _B, int _C)
        {
            int perim;
            perim = _A + _B + _C;
            Console.WriteLine("Perimeter of the triangle: {0}", perim);
            return perim;
        }
        public static double getArea(int _A, int _B, int _C)
        {
            
            double area;
            double s = (_A + _B + _C) / 2;
            area = Math.Sqrt(s * (s - _A) * (s - _B) * (s - _C));
            Console.WriteLine("Area of the triangle: {0}", area);
            return area;
        }
    }
}
