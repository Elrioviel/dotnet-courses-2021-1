using System;
using System.Collections.Generic;

namespace Task4
{
    class Program
    {
        public static int[,] GenerateArray()
        {
            Random randNum = new Random();
            int[,] randArray = new int[3, 5];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    randArray[i, j] = randNum.Next(1, 10);
                    Console.Write(string.Format("{0} ", randArray[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
            return randArray;
        }

        public static int GetSumOfElementsOnEvenPositions(int[,] randArray)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i+j)%2 == 0)
                    {
                        sum += randArray[i, j];
                    }
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            var newRandArray = GenerateArray();
            var sum = GetSumOfElementsOnEvenPositions(newRandArray);
            Console.WriteLine("The sum of elements on even positions = {0}", sum);
            Console.ReadLine();
        }
    }
}
