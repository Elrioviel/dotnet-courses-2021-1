using System;
using System.Collections;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var arrayOfInteger3 = new MyDynamicArray<int>(new List<int> { 3, 5, 6, 7, 8, 9 });

            foreach (var item in arrayOfInteger3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
