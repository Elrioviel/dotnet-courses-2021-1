using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static string WriteTextFrom()
        {
            string text = "This is is a RANDOM random ,rand  text with with with with with ::random words! Doesn't doesn't anysense sense;???";
            return text;
        }
        static Dictionary<string,int> CalculateOccurence(string text)
        {
            Dictionary<string, int> stats = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            char[] seperate = { ' ', ',', ';', '.', '?', '!', ':', '-', '[', ']', '(', ')', '}', '{', '\n', '\r' };
            string[] words = text.Split(seperate);
            foreach (string word in words)
            {
                string wordTrimmed = word.Trim().ToLower();
                if (wordTrimmed.Length>1)
                {
                    if (!stats.ContainsKey(wordTrimmed))
                    {
                        stats.Add(wordTrimmed, 1);
                    }
                    else
                        stats[wordTrimmed] += 1;
                }
            }
            return stats;
        }
        static int CalculatePunctuation(string text)
        {
            int countPunct = Regex.Matches(text, @"(?=[?!.,;:\s])+").Count;
            return countPunct;
        }
        static void Main(string[] args)
        {
            string text = WriteTextFrom();
            Dictionary<string, int> stats = CalculateOccurence(text);
            int punct = CalculatePunctuation(text);
            foreach (var word in stats)
            {
                Console.WriteLine("Total occurences of the word {0} = {1}", word.Key, word.Value);
            }
            Console.WriteLine("Punctuation: {0}", punct);
            
        }
    }
}
