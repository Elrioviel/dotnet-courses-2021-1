using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class MyDynamicArray<T> 
    {
        private T[] myArray;
        private int size;
        private int count;

        //1: array of 8 elements
        public MyDynamicArray()
        {
            count = 8;
            this.myArray = new T[count];
            
        }
        //2: constructor of 1 parameter
        public MyDynamicArray(int capacity)
        {
            myArray = new T[capacity];

        }
        //3:constructor w/ array parameter
        public MyDynamicArray(IEnumerable<T> source)
        {
            myArray = source.ToArray();
            size = myArray.Length;
            count = myArray.Length;
        }
        //4: Add method and doubles the array's size and Adds element
        public void Resize(int index)  
        {
            if (count <= index)
                {
                    count *= 2;
                }
            T[] doubledArray = new T[count];
            for (var i = 0; i < myArray.Length; i++)
            {
                doubledArray[i] = myArray[i];
            }
            myArray = doubledArray;
        }
        public void Add(T obj)
        {
            
            if (count == size)
            {
                Array.Resize(ref myArray, size * 2);
            }
            myArray[size] = obj;
            size++;
        }
        
        //5: AddRange
        public void AddRange (T[] elements)
        {
            var sizeOfElements = elements.Length;
            if ((size == count) || ((count - size) <= elements.Length))
            {
                Array.Resize<T>(ref myArray, count + sizeOfElements );
                
            }
            
            Array.Copy(elements, 0, myArray, size, elements.Length);
        }
        //6: delete a specific element from array
        public T[] Remove(T toDeleteElement)
        {
            
            int indexToDelete = Array.IndexOf(myArray, toDeleteElement);
            if (indexToDelete == -1)
            {
                throw new IndexOutOfRangeException();
            }
            size -= 1;
            Array.Copy(myArray, 0, myArray, 0, indexToDelete);
            Array.Copy(myArray, indexToDelete + 1, myArray, indexToDelete, count - indexToDelete - 1);
            
            return myArray;

        }

        //7
        public T[] Insert(T obj, int index)
        {

            T[] arrayObjInserted = new T[myArray.Length + 1];
            T[] objToArray = new T[] { obj };

            if (index >= myArray.Length)
            { throw new IndexOutOfRangeException($"The collection can hold only {myArray.Length} elements."); }
            else
            {
                Array.Copy(myArray, 0, arrayObjInserted, 0, index);
                Array.Copy(objToArray, 0, arrayObjInserted, index, 1);
                Array.Copy(myArray, index, arrayObjInserted, index + 1, myArray.Length / 2);
            }

                 return arrayObjInserted;
            

        }
        //8
        public int Length()
        {
            size = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] != null)
                { size++; }

            }

            return size;
        }
        //9
        public int Capacity()
        {
            
            count = myArray.Length;
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
