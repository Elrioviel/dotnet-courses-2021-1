using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDPoint point1 = new TwoDPoint(1, 1);
            TwoDPoint point2 = new TwoDPoint(10, 10);

            object object1 = (object)point1;
            object object2 = (object)point2;

            Console.WriteLine(point1.Equals(point2));
            Console.WriteLine(point1 == point2);

            Console.WriteLine(object1.Equals(object2));
            Console.WriteLine(object1 == object2);
            Console.WriteLine("Hash for point1: {0}\tHash for point2: {1}", point1.GetHashCode(), point2.GetHashCode());
            
            TwoDPointWithHash newPoint1 = new TwoDPointWithHash(1, 10);
            TwoDPointWithHash newPoint2 = new TwoDPointWithHash(10, 1);

            

            Console.WriteLine("Hash for point1: {0}\tHash for point2: {1}", newPoint1.GetHashCode(), newPoint2.GetHashCode());
            Console.WriteLine("TwoDPoint:");

            var twoDPointList = new List<TwoDPoint> { point1, point2 };
            var distinctTwoDPointList = twoDPointList.Distinct();
            foreach (var point in distinctTwoDPointList)
            {
                Console.WriteLine("Distinct point: {0}", point);
            }

            
            Console.WriteLine("TwoDPointWithHash:");

            var twoDPointWithHashList = new List<TwoDPointWithHash> { newPoint1, newPoint2 };
            var distinctTwoDPointWithHashList = twoDPointWithHashList.Distinct();
            foreach (var point in distinctTwoDPointWithHashList)
            {
                Console.WriteLine("Distinct point: {0}", point);
            }
        }
    }
}
