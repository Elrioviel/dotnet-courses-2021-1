using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    class Program
    {

        static void Main(string[] args)
        {

            int a = 0;
            int b = 0;
            int c = 0;

            Console.WriteLine("************Hello user! This program helps you calculate the area of a rectangle************");
            Console.WriteLine("First, you need to enter the length and width of the rectangle. If the values you entered meet the conditions listed below, you will get the result by pressing the Enter button!");
            Console.WriteLine("Please note: The numbers you enter must be positive!");
            Console.WriteLine("                          ************************************                              ");

            Console.WriteLine("Enter the length of the rectangle : ");
            a = Convert.ToInt32(Console.ReadLine());

            while (a <= 0)
            {
                Console.WriteLine("You entered an invalid number. Please make sure you enter a positive number: ");
                a = Convert.ToInt32(Console.ReadLine());
            }




            Console.WriteLine("Enter the width of the rectangle : ");
            b = Convert.ToInt32(Console.ReadLine());
            while (b <= 0)
            {
                Console.WriteLine("You entered an invalid number. Please make sure you enter a positive number: ");
                b = Convert.ToInt32(Console.ReadLine());

            }





            c = a * b;
            Console.WriteLine("The area of the rectangle is = {0}", c);
            Console.ReadLine();

        }

    }
}
