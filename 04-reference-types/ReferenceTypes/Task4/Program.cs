using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding strings:");
            MyString firstStringToAdd = new MyString("Hello");
            MyString secondStringToAdd = new MyString("world");
            string thirdString = firstStringToAdd + secondStringToAdd;
            Console.WriteLine(thirdString);

            Console.WriteLine("Comparing strings: ");
            MyString firstStringToCompare = new MyString("Hello");
            MyString secondStringToCompare = new MyString("Hello");
            bool compareEqual = firstStringToCompare == secondStringToCompare;
            Console.WriteLine(compareEqual);
            bool compareInequal = firstStringToCompare != secondStringToCompare;
            Console.WriteLine(compareInequal);

            Console.WriteLine("deleting strings:");
            MyString firstStringToDelete = new MyString("Hello hello world");
            MyString secondStringToDelete = new MyString("hello");
            string newString = firstStringToDelete - secondStringToDelete;
            Console.WriteLine(newString);

        }
    }
}
