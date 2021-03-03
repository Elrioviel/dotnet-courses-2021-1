using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> add_list = new List<int>() { 3,5};
            for (int i = 4; i <=1000; i++)
            {
                if (i % 3 == 0)
                {
                    add_list.Add(i);
                }
    

             }
            for (int i = 6; i <= 1000; i++)
            {
                if (i % 5 == 0)
                {
                    add_list.Add(i);
                }

                
            }
            int sumValues = add_list.Sum();
            Console.Write(sumValues);
            Console.ReadKey();
        }
    }
}
