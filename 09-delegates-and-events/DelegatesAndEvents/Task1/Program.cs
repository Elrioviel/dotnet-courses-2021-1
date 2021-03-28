using System;

namespace Task1
{
    class Program
    {
        public static int CompareStrings(string firstString, string secondString)
        {
            int compared;
            if (firstString.Length > secondString.Length)
            {
                compared = 1;
            }
            else if (firstString.Length > secondString.Length)
            {
                compared = -1;
            }
            else
            {
                compared = string.Compare(firstString, secondString);
                
            }
            return compared;
        }
        public delegate int MyDelegate(string firstString, string secondString);
        public static void Sort(string[] stringToSort, MyDelegate MyDelegate)
        {
            //MyDelegate d1 = new MyDelegate (CompareStrings);
            for (var i = 0; i < stringToSort.Length -1; i++)
            {
                for (var j = i + 1; j < stringToSort.Length; j++)
                {
                    int biggerOrSmaller = MyDelegate(stringToSort[i], stringToSort[j]);
                    if (biggerOrSmaller == 1)
                    {
                        string temp = stringToSort[i];
                        stringToSort[i] = stringToSort[j];
                        stringToSort[j] = temp;


                    }
                }
            }
            for (var i = 0; i < stringToSort.Length; i++)
            {
                Console.Write("{0} | ", stringToSort[i]);
            }
        }
        
        static void Main(string[] args)
        {
            string[] myStringToSort = new string[] { "hiiii", "hii", "hiii", "abc", "hi" };
            MyDelegate d1 = new MyDelegate(CompareStrings);
            Sort(myStringToSort, d1);
        }
    }
}
