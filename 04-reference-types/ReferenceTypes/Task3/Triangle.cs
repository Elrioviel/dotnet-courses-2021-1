using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task3
{
    class Triangle
    {
        public int A;
        public int B;
        public int C;

        public Triangle(int aValue, int bValue, int cValue)
        {
            A = aValue;
            B = bValue;
            C = cValue;

        }
        public int CalculatePerimeter()
        {
            int perim;
            perim = A + B + C;
            
            return perim;
        }
        public double CalculateArea()
        {
            double area;
            double s = (A + B + C) / 2;
            area = Math.Sqrt(s * (s - A) * (s - B) * (s - C));
            return area;
        }
    }
}
