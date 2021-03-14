using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                Console.WriteLine("Input first side of triangle: ");
                int aValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input second side of triangle: ");
                int bValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input third side of triangle: ");
                int cValue = Convert.ToInt32(Console.ReadLine());

                Triangle t1 = new Triangle(aValue,bValue,cValue);
                Triangle.calculatePerimeter(aValue, bValue, cValue);
                Triangle.calculateArea(aValue, bValue, cValue);
            }
            catch
            {
                Console.WriteLine("Error occured");
            }
        }
    }
}
