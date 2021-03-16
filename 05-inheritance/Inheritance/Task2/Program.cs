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
            var circumference = Round.CalculatePerimeter(3, 6, 25);
            Console.WriteLine("Perimeter: {0}", circumference);
            var area = Round.CalculateArea(3, 6, 25);
            Console.WriteLine("Area: {0}", area);
            Console.WriteLine();
            Circle circle1 = new Circle(1, 2, 25, 16);
            Console.WriteLine("Circle:");
            Console.WriteLine("X = {0}", circle1.X);
            Console.WriteLine("Y = {0}", circle1.Y);
            Console.WriteLine("Radius = {0}", circle1.InnerRadius);
            var circleCircumference = Circle.CalculateCirclePerimeter(16);
            Console.WriteLine("Perimeter: {0}", circleCircumference);
            var circleArea = Circle.CalculateCircleArea(3, 6, 16);
            Console.WriteLine("Area: {0}", circleArea);
            var sumCircumference = Circle.CalculateSumCircumferences(circumference, circleCircumference);
            Console.WriteLine("Sum of inner and outer circumferences: {0}", sumCircumference);
            Console.ReadLine();
        }
    }
}
