using System;
using System.Collections;
using System.Collections.Generic;
namespace Task1
{
    class Program
    {
        public static void RemoveEachSecondItem(IEnumerable<string> Person)
        {
            LinkedList<string> Person1 = new LinkedList<string>(Person);
            var prevItem = Person1.First;
            var currentItem = prevItem.Next;
            if (prevItem != null && currentItem != null)
            {
                var temp = prevItem.Next;
                temp = currentItem.Next;
                currentItem = null;
                prevItem = prevItem.Next;
                if (prevItem != null)
                    currentItem = prevItem.Next;
            }
            Console.WriteLine(Person1.First.Value);
            
        }
        
        static void Main(string[] args)
        {
            string[] PersonM = { "Dave", "John", "Michael", "Gordon", "Simon", "Falcone" };
            string[] PersonF = { "Laura", "Clair", "Sarah", "Lucy", "Mary", "Elen" };
            LinkedList<string> Person1 = new LinkedList<string>(PersonM);
            List<string> Person2 = new List<string>(PersonF);
            RemoveEachSecondItem(Person1);
            RemoveEachSecondItem(Person2);
            
        }
    }
}
