using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task6
{
    class NumCheck
    {
        public static void Check(){
            string input = Console.ReadLine();

            Regex simpleNotation = new Regex(@"^\d+.\d+$");
            var scientificNotation = new Regex(@"^-?\d+.\d+e-?\d+.\d+$");

            if (simpleNotation.IsMatch(input))
            {
                Console.WriteLine("This number is in simple notation");
            }
            else if (scientificNotation.IsMatch(input))
            {
                Console.WriteLine("This number is in scientific notation");
            } else
            {
                Console.WriteLine("This is not a number");
            }

        }
        
    }
}
