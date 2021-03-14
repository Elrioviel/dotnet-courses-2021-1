using System;

namespace Task2
{
    class Round
    {
        public int X;
        public int Y;
        public int Radius;

        public Round(int xValue, int yValue, int radiusValue)
        {
            X = xValue;
            Y = yValue;
            Radius = radiusValue;
        }
        public static double calculateArea(int xValue, int yValue, int radiusValue)
        {
            double area = Math.PI * radiusValue * radiusValue;
            Console.WriteLine("Area: {0}", area);
            return area;
        }

        public static double calculatePerimeter(int xValue, int yValue, int radiusValue)
        {

            double circumference = 2 * Math.PI * radiusValue;
            Console.WriteLine("Perimeter: {0}", circumference);
            return circumference;
        }
    }
    class Circle : Round
    {
            public int innerRadius;
        
        public Circle(int xValue, int yValue, int radiusValue, int innerRadius): base (xValue,yValue,radiusValue)
        {
            if (innerRadius>radiusValue)
            {
                throw new ArgumentException("Radius must be greater than the inner radius!");
            }
            this.innerRadius = innerRadius;
        }
        public static double calculateCircleArea(int xValue, int yValue, int innerRadius)
        {
            double circleArea = Math.PI * innerRadius * innerRadius;
            Console.WriteLine("Area: {0}", circleArea);
            return circleArea;
        }

        public static double calculateCirclePerimeter(int xValue, int yValue, int innerRadius)
        {

            double circleCircumference = 2 * Math.PI * innerRadius;
            Console.WriteLine("Perimeter: {0}", circleCircumference);
            return circleCircumference;
        }

        public static double calculateSumCircumferences(double circumference, double circleCircumference)
        {
            double sumOfCircumferences = circumference + circleCircumference;
            Console.WriteLine("Sum of inner and outer circumferences: {0}", sumOfCircumferences);
            return sumOfCircumferences;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Round round1 = new Round(3, 6, 25);
            Console.WriteLine("Round:");
            Console.WriteLine("X = {0}", round1.X);
            Console.WriteLine("Y = {0}", round1.Y);
            Console.WriteLine("Radius = {0}", round1.Radius);
            var roundCircumference = Round.calculatePerimeter(3, 6, 25);
            Round.calculateArea(3, 6, 25);
            Console.WriteLine();
            Circle circle1 = new Circle(1, 2, 25, 16);
            Console.WriteLine("Circle:");
            Console.WriteLine("X = {0}", circle1.X);
            Console.WriteLine("Y = {0}", circle1.Y);
            Console.WriteLine("Radius = {0}", circle1.innerRadius);
            var circleCircumference = Circle.calculateCirclePerimeter(3,6,16);
            Circle.calculateCircleArea(3, 6, 16);
            Console.WriteLine();
            Circle.calculateSumCircumferences(roundCircumference,circleCircumference);
            Console.ReadLine();
        }
    }
}
