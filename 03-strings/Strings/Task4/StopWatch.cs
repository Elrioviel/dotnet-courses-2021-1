using System;
using System.Diagnostics;
using System.Threading;
using System.Text;

namespace Task4
{
    class StopWatch
    {
        public static string GetsbTime()
        {
            Stopwatch myTimer = new Stopwatch();
            StringBuilder sb = new StringBuilder();
            int N = 100;
            myTimer.Start();

            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            myTimer.Stop();
            var sBuilderTime = myTimer.ElapsedMilliseconds;
            return sBuilderTime.ToString();
        }
        public static string GetstrTime()
        {
            Stopwatch myTimer = new Stopwatch();
            string str = "";
            myTimer.Start();
            int N = 100;

            for (int i = 0; i < N; i++)
            {
                str += "*";
            }

            myTimer.Stop();
            var strTime = myTimer.ElapsedMilliseconds;
            return strTime.ToString();
        }

    }
}
