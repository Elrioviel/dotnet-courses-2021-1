using System;

namespace Task3
{
    class Program
    {
        public static void PrintSeries(ISeries series, int sequenceLength)
        {
            series.Reset();
            for (int i=0; i < sequenceLength; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }
        public static void PrintIndexable(IIndexableSeries series2, int sequenceLength)
        {
            series2.Reset();
            for (int i=0; i < sequenceLength; i++)
            {
                Console.WriteLine(series2.GetCurrent());
                series2.MoveNext();
            }

        }
        public static void Main(string[] args)
        {
            ISeries progression = new ArithmeticProgression(2, 3);
            Console.WriteLine("Arithmetic progression:");
            PrintSeries(progression, 5);

            IIndexableSeries list = new List(new double[] { 1, 3, 5, 7, 9 });
            Console.WriteLine("List:");
            PrintIndexable(list, 10);
        }
    }
}
