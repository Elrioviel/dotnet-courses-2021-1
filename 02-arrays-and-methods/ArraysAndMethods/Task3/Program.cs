using System;

namespace Task3
{
    class Program
    {
        public static int[] GenerateArray()
        {
            Random rand = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    arr[i] = rand.Next(1, 10);

                else
                    arr[i] = (rand.Next(1, 10)) * -1;
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            return arr;
        }

        public static int GetSumOfNonNegativeElements(int[] arr)
        {
            int sum = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            var rand = GenerateArray();
            var sum = GetSumOfNonNegativeElements(rand);
            Console.WriteLine("The sum of non negative elements = {0}", sum);
            Console.ReadLine();
        }
        
    }
}
