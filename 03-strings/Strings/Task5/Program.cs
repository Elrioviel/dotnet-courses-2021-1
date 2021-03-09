using System;
using System.Text.RegularExpressions;
namespace Task5
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter HTML line: ");
            String sentence = Console.ReadLine();
            string sentence_trim = Regex.Replace(sentence, @"<(.+?)>", "_");
            Console.WriteLine("Result= {0} ", sentence_trim);
        }
    }
}
