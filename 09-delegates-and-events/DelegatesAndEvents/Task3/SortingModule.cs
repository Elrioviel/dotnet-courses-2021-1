using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    
    class SortingModule
    {
        public delegate void TaskHandler(string message);
        public static event TaskHandler Notify;
        //public static event EventHandler<string[]> TaskCompleted;
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
        
        public static void Sort(string[] stringToSort, Delegate MyDelegate)
        {
            MyDelegate d1 = new MyDelegate(CompareStrings);
            for (var i = 0; i < stringToSort.Length - 1; i++)
            {
                for (var j = i + 1; j < stringToSort.Length; j++)
                {
                    int biggerOrSmaller = d1(stringToSort[i], stringToSort[j]);
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
            Thread.Sleep(300);
            Notify?.Invoke("Task Completed");

        }
        

    }
}
