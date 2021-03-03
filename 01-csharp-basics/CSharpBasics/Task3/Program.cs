using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y, z;
            Console.WriteLine("Hello user! This program prints pyramid star pattern depending on the number of rows you enter! ");
            Console.WriteLine("Enter the number of rows: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n == 0)
            {
                Console.WriteLine("You entered an invalid number");
                n = Convert.ToInt32(Console.ReadLine());
            }
            for (x = 1; x <= n; x++)
            {
                for (y = x; y < n; y++)
                {
                    Console.Write(" ");
                }
                for (z = 1; z < (x * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
