using System;
using System.Collections.Generic;

namespace Task1
{
    public static class ArrayMethods
    {

        public static int[] GenerateArray() {
            var randomizer = new Random();
            var result = new List<int>();
            for (var i = 0; i < 10; i++)
            {
                result.Add(randomizer.Next());
            }

            return result.ToArray();
        }

        public static int[] SortAndGetMinAndMaxValues(int[] randArray, out int max, out int min)
        {
            for (var i = 0; i < randArray.Length - 1; i++)
            {
                for (var j = i + 1; j < randArray.Length; j++)
                {
                    if (randArray[i] > randArray[j])
                    {
                        var temp = randArray[i];
                        randArray[i] = randArray[j];
                        randArray[j] = temp;
                    }
                }

            }

            max = randArray[^1];
            min = randArray[0];

            return randArray;
        }

        public static void PrintArray(int[] randArray)
        {
            foreach (var item in randArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
