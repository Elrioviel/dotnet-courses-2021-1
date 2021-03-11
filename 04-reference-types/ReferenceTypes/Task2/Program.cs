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
                Console.WriteLine("X = {0}", r1._xValue);
                Console.WriteLine("Y = {0}", r1._yValue);
                Console.WriteLine("Radius = {0}", r1._radius);
                Round.getPerim(3, 6, 25);
                Round.getArea(3, 6, 25);

            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
            }
        }
    }
}
