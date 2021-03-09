using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text: ");
            string input = Console.ReadLine();
            string times = (@"([0-1]?[0-9]|2[0-3]):[0-5][0-9]");
            int numberOfTrues = Regex.Matches(input, times).Count;
            Console.WriteLine("Time was mentioned {0} times.", numberOfTrues);
        }
    }
}
