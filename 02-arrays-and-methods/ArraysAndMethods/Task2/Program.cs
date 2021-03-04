using System;

namespace Task2
{
    class Program
    {
        public static int[,,] GenerateArray()
        {
            Random randarray = new Random();
            int[,,] arr = new int[2, 5, 3];
            for (var i = 0; i < 2; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    for (var k = 0; k < 3; k++)
                    {
                        if (i % 2 == 0)
                        {
                            arr[i, j, k] = randarray.Next(1, 10);
                        }
                        else
                        {
                            arr[i, j, k] = (randarray.Next(1, 10)) * -1;
                        }

                        Console.Write(arr[i, j, k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            return arr;
        }

        public static void ReplacePositiveElementsWithZero(int[,,] arr)
        {
            for (var i = 0; i < 2; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    for (var k = 0; k < 3; k++)
                    {
                        if (arr[i, j, k] > 0)
                        {
                            arr[i, j, k] = 0;
                        }
                        Console.Write(arr[i, j, k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            var positiveNum = GenerateArray();
            ReplacePositiveElementsWithZero(positiveNum);
           
        }
    }
}
