using System;
using System.Collections;
using System.Collections.Generic;
namespace Task1
{
    class Program
    {
        public static void RemoveEachSecondItem(IEnumerable<string> oldPerson)
        {
            List<string> Person1 = new List<string>();
            List<string> Person = new List<string>(oldPerson);
            bool isEven = false;

            do
            {
                Person1 = new List<string>();
                foreach (string element in Person)
                {
                    if (isEven)
                        Person1.Add(element);
                    isEven = !isEven;
                }


                Person = new List<string>(Person1);
               
            }
            while (Person1.Count > 1);


            Console.WriteLine(Person1[0]);
            
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
