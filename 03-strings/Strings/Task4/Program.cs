using System;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Task4
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string sbTimer = StopWatch.GetsbTime();
            Console.WriteLine("StringBuilder: {0}", sbTimer);
            string stTimer = StopWatch.GetstrTime();
            Console.WriteLine("String: {0}", stTimer);
        }
    }
  
}
