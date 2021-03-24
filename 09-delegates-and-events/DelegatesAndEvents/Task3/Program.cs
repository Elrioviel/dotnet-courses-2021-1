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
        static async void SortAsync(string [] myStringToSort, SortingModule.MyDelegate d1)
        {
            Console.WriteLine("sorting method started");
            await Task.Run(() => SortingModule.Sort(myStringToSort, d1));
            Console.WriteLine("\nsorting method finished");
        }
        static void Main(string[] args)
        {
            
            string[] myStringToSort = new string[] { "hiiii", "hii", "hiii", "abc", "hi" };
            SortingModule.MyDelegate d1 = new SortingModule.MyDelegate(SortingModule.CompareStrings);
            SortAsync(myStringToSort,d1);
            Console.Read();
        }

    }
}
