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
                var perim = t1.CalculatePerimeter();
                Console.WriteLine("Perimeter of the triangle: {0}", perim);
                var area = t1.CalculateArea();
                Console.WriteLine("Area of the triangle: {0}", area);

            }
            catch
            {
                Console.WriteLine("Error occured");
            }
        }
    }
}
