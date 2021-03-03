using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            Console.WriteLine("Hello user! This program prints right triangle star pattern depending on the number of rows you enter! ");
            Console.WriteLine("Enter the number of rows: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n == 0)
            {
                Console.WriteLine("You entered an invalid number");
                n = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }
            Console.ReadLine();
        }
    }
}
