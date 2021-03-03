using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var unsortedArray = ArrayMethods.GenerateArray();
            var sortedArray = ArrayMethods.SortAndGetMinAndMaxValues(unsortedArray, out var max, out var min);
            ArrayMethods.PrintArray(sortedArray);
            
            Console.WriteLine(min);
            Console.WriteLine(max);

            Console.ReadLine();
        }
    }
}
