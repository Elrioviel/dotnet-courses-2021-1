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
        public static int calculatePerimeter(int aValue, int bValue, int cValue)
        {
            int perim;
            perim = aValue + bValue + cValue;
            Console.WriteLine("Perimeter of the triangle: {0}", perim);
            return perim;
        }
        public static double calculateArea(int aValue, int bValue, int cValue)
        {
            
            double area;
            double s = (aValue + bValue + cValue) / 2;
            area = Math.Sqrt(s * (s - aValue) * (s - bValue) * (s - cValue));
            Console.WriteLine("Area of the triangle: {0}", area);
            return area;
        }
    }
}
