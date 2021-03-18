using System;

namespace Task2
{
    class Program
    {
        static void PrintSeries(ISeries series, int sequenceLength)
        {
            series.Reset();
            for (int i = 0; i< sequenceLength; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }
        static void Main(string[] args)
        {
            ISeries geoProgression = new GeometricProgression(2, 3);
            Console.WriteLine("Geometric progression:");
            PrintSeries(geoProgression, 5);
        }
    }
}
