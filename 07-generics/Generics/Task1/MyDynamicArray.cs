using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class MyDynamicArray<T> 
    {
        T[] myArray;
        int size;
         

        //1: array of 8 elements
        public MyDynamicArray()
        {
            size = 8;
            this.myArray = new T[size];
            
        }
        //2: constructor of 1 parameter
        public MyDynamicArray(int length)
        {
            myArray = new T[length];
        }
        //3:constructor w/ array parameter
        public MyDynamicArray(IEnumerable<T> source)
        {
            myArray = source.ToArray();
        }
        //4: Add method and doubles the array's size and Adds element
         public void Add(T obj)
        {
            
            if (myArray[^1] != null)
            {
                var myArrayLength = myArray.Length;
                Array.Resize(ref myArray, myArrayLength * 2);
            }

            var lastElement = Array.FindLast(myArray, x => x != null);
            int index = Array.IndexOf(myArray, lastElement);
            myArray[index] = obj;

        }
        //5: AddRange
        public void AddRange (T[] elements)
        {
            var myArrayLength = myArray.Length;
            Array.Resize<T>(ref myArray, myArrayLength + elements.Length);
            Array.Copy(elements, 0, myArray, myArrayLength, elements.Length);
        }
        //6: delete a specific element from array
        public T[] Remove(T toDeleteElement)
        {
            T[] finalArray = new T[myArray.Length-1];
            int indexToDelete = Array.IndexOf(myArray, toDeleteElement);
            Array.Copy(myArray, 0, finalArray, 0, indexToDelete);
            Array.Copy(myArray, indexToDelete + 1, finalArray, indexToDelete, myArray.Length - indexToDelete - 1);
            
            return finalArray;

        }

        //7
        public T[] Insert(T obj, int index)
        {
            try
            {

                T[] arrayObjInserted = new T[myArray.Length + 1];
                T[] objToArray = new T[] { obj};

                Array.Copy(myArray, 0, arrayObjInserted, 0, index);
                Array.Copy(objToArray, 0, arrayObjInserted, index, 1);
                Array.Copy(myArray, index, arrayObjInserted, index + 1, myArray.Length/2);

                 return arrayObjInserted;
            }
            catch
            {
                throw new ArgumentOutOfRangeException("index");

            }

        }
        //8
        public int Length()
        {
            return myArray.Length;
        }
        //9
        public int Capacity()
        {
            int count = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] != null) 
                { count++; }

            }

            return count;
        }
        //10
        public T this[int i]
        {
            get
            {
                return myArray[i];
            }
            set
            {
                if (i >= myArray.Length)
                    throw new IndexOutOfRangeException($"The collection can hold only {myArray.Length} elements.");
                else
                myArray[i] = value;
            }
        }
    }
}
