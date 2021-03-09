using System;
using System.Linq;


namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] textSplit;
            var sumChar = 0;
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();
            char[] charsToTrim = { ' ', ',', ';', '.', '?', '!', ':', '-', '[', ']', '(', ')', '}', '{' };
            string trimmedSentence = sentence.Trim(charsToTrim);
            textSplit = trimmedSentence.Split(charsToTrim, StringSplitOptions.RemoveEmptyEntries);
                for (var i = 0; i < textSplit.Length; i++)
                {
                   sumChar += textSplit[i].Length;
                }
            int sumWords = textSplit.Length;
            int avWord = sumChar / sumWords;
                foreach (var item in textSplit)
                {
                    Console.WriteLine(item);
                }
            Console.WriteLine("Number of letters of the input sentence: {0} \nthe number of words of the sentence: {1} \nthe average word has {2} letters", sumChar, sumWords, avWord);
        }
    }
}
   