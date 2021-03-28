using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {

        static Thread SortAsync(string [] myStringToSort, SortingModule.MyDelegate d1)
        {
            Thread t = new Thread(() => { SortingModule.Sort(myStringToSort, d1); });
            t.Start();
            return t;
        }
        
        static void Main(string[] args)
        {
            SortingModule.Notify += Notify_Task_Complete;
            string[] myStringToSort = new string[] { "hiiii", "hii", "hiii", "abc", "hi" };
            SortingModule.MyDelegate d1 = new SortingModule.MyDelegate(SortingModule.CompareStrings);
            SortAsync(myStringToSort,d1);
            
        }

        private static void Notify_Task_Complete(string message)
        {
            Console.WriteLine(message);
        }
    }
}
