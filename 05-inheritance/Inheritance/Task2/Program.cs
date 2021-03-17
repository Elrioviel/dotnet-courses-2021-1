using System;

namespace Task2
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Round round1 = new Round(3, 6, 25);
            Console.WriteLine("Round:");
            Console.WriteLine("X = {0}", round1.X);
            Console.WriteLine("Y = {0}", round1.Y);
            Console.WriteLine("Radius = {0}", round1.Radius);
            var circumference = round1.CalculatePerimeter();
            Console.WriteLine("Perimeter: {0}", circumference);
            var area = round1.CalculateArea();
            Console.WriteLine("Area: {0}", area);
            Console.WriteLine();

            Circle circle1 = new Circle(1, 2, 25, 16);
             var diffArea = circle1.CalculateAreaDifferencee();
            Console.WriteLine("The difference is: {0}", diffArea);
            var sumCircumference = circle1.CalculateSumCirclePerimeter();
            Console.WriteLine("Sum of inner and outer circumferences: {0}", sumCircumference);
            Console.ReadLine();
        }
    }
}
