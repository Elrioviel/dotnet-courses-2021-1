using System;
using MathLibrary;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a numbers, you wish to calculate its factorial:");
            int number = int.Parse(Console.ReadLine());
            int result = MathFunctions.Factorial(number);
            Console.WriteLine("Factorial of {0} is: {1}", number, result);
            Console.WriteLine("Enter x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y:");
            int y = int.Parse(Console.ReadLine());
            double powerResult = MathFunctions.Power(x, y);
            Console.WriteLine("Result: {0}", powerResult);
        }
    }
}
