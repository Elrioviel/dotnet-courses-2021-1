using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("Hello user! Please enter the number of triangles: ");
            N = Convert.ToInt32(Console.ReadLine());
            while (N == 0)
            {
                Console.WriteLine("You entered an invalid number");
                N = Convert.ToInt32(Console.ReadLine());
            }
            var triangles = new List<Triangle>();
            for (var i = 1; i <= N; i++)
            {
                triangles.Add(new Triangle(i, N));
            }

            foreach (var triangle in triangles)
            {
                Console.Write(triangle);
            }

            Console.ReadKey();
        }
    }
}
