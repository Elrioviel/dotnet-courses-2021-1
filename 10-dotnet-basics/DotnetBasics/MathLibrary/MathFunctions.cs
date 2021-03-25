using System;

namespace MathLibrary
{
    public class MathFunctions
    {
        public static int Factorial(int number)
        {
            int fact = 1;
            for (var i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        public static double Power(double x, double y)
        {
            double result;
            result = Math.Pow(x, y);
            return result;
        }
    }
}
