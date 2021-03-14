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
                Round.calculatePerimeter(3, 6, 25);
                Round.calculateArea(3, 6, 25);

            }
            catch
            {
                Console.WriteLine("Error occured");
            }
        }
    }
}
