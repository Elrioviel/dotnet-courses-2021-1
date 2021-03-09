using System;
using System.Linq;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the first sentence: ");
            string sentence1 = Console.ReadLine();
            Console.WriteLine("Enter the second sentence: ");
            string sentence2 = Console.ReadLine();

            var result = new StringBuilder();
            
            foreach (var c in sentence1)
            {
                result.Append(sentence2.Contains(c) ? $"{c}{c}" : $"{c}");
            }

            Console.WriteLine("merged strings:{0} ", result.ToString());
            Console.ReadLine();
        }
    }
}
