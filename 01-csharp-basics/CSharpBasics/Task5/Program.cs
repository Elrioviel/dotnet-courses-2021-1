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
            List<int> add_list = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) | (i % 5 ==0))
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
