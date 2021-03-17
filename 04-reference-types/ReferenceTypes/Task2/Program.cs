using System;

namespace Task2
{
class Program
    {
        static void Main(string[] args )
        {
            try
            {
                Round r1 = new Round(3,6,25);
                Console.WriteLine("X = {0}", r1.X);
                Console.WriteLine("Y = {0}", r1.Y);
                Console.WriteLine("Radius = {0}", r1.Radius);
                var circumference = r1.CalculatePerimeter();
                Console.WriteLine("Perimeter: {0}", circumference);
                var area = r1.CalculateArea();
                Console.WriteLine("Area: {0}", area);

            }
            catch
            {
                Console.WriteLine("Error occured");
            }
        }
    }
}
