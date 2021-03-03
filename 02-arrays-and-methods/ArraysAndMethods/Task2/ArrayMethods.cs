using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class ArrayMethods
    {
        public static int[,,] GenerateArray()
        {
            Random randarray = new Random();
            int[,,] arr = new int[10, 5, 3];
            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    for (var k = 0; k < 3; k++)
                    {
                        if (i % 2 == 0)
                            arr[i, j, k] = randarray.Next(1, 10);

                        else
                            arr[i, j, k] = (randarray.Next(1, 10)) * -1;
                    }
                }
            }
            

            return arr;
        }


        public static void ReplacePositiveElementsWithZero(int[,,] randarray)
        {
            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    for (var k = 0; k < 3; k++)
                    {

                        {
                            randarray[i, j, k] = 0;
                        }
                    }
                }
            }
            foreach (var item in randarray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
