
using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            //testing with object array

            object[] array = new object[8];
            array[0] = 1;
            array[1] = "hello";
            array[2] = 0.25;
            array[3] = 'c';
            array[4] = 4555745215658445578;
            array[5] = "world";

            MyDynamicArray<object> array2 = new MyDynamicArray<object>();
            array2.Add("hi");


            array2.AddRange(array);
            int arrayLength = array2.Length();
            int arrayCapacity = array2.Capacity();
            Console.WriteLine("Array's length: {0}, array's capacity: {1}", arrayLength, arrayCapacity);
            array2.Remove(0.25);
            Console.WriteLine("Array's length: {0}, array's capacity: {1}", arrayLength, arrayCapacity);


            //testing with integer array
            int[] arrayOfInteger = new int[] { 1, 3, 6};
            MyDynamicArray<int> arrayOfInteger2 = new MyDynamicArray<int>();
            var arrayOfInteger3 = new MyDynamicArray<int>(new List<int> { 3, 5, 6, 7, 8, 9 });
            

            arrayOfInteger3.AddRange(arrayOfInteger);
            Console.WriteLine("AddRange: ");
            for (var i = 0; i < arrayOfInteger3.Length(); i++)
            {
                Console.WriteLine(arrayOfInteger3[i]);
            }

            int arrayOfIntegerLength = arrayOfInteger3.Length();
            int arrayOfIntegerCapacity = arrayOfInteger3.Capacity();
            Console.WriteLine("Array's length: {0}, capacity: {1}", arrayOfIntegerLength, arrayOfIntegerCapacity);
            Console.WriteLine("\t************************");
            
            arrayOfInteger3.Add(35);
            int arrayOfIntegerLengthAfterAdd = arrayOfInteger3.Length();
            int arrayOfIntegerCapacityAfterAdd = arrayOfInteger3.Capacity();
            Console.WriteLine("Array's length after adding one element: {0}, capacity: {1}", arrayOfIntegerLengthAfterAdd, arrayOfIntegerCapacityAfterAdd);
            

            Console.WriteLine("\t************************");
            Console.WriteLine("Removing 8 from integer array:");

            int [] arrayOfInteger4 = arrayOfInteger3.Remove(8);
            for (var i = 0; i < arrayOfInteger4.Length; i++)
            {
                Console.WriteLine(arrayOfInteger4[i]);
            }

            Console.WriteLine("\t************************");
            Console.WriteLine("Inserting '132' at index '5':");
            int[] arrayOfInteger5 = arrayOfInteger3.Insert(132, 5);

            for (var i = 0; i < arrayOfInteger5.Length; i++)
            {
                Console.WriteLine(arrayOfInteger5[i]);
            }

            Console.WriteLine("\t************************");
            Console.WriteLine("Displaying the seventh element: {0}", arrayOfInteger5[7]);
            
        }
    }

}
