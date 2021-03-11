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
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input second side of triangle: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input third side of triangle: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Triangle t1 = new Triangle(a,b,c);
                Triangle.getPerimeter(a, b, c);
                Triangle.getArea(a, b, c);
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
            }
        }
    }
}
