using System;
using System.Collections;
using System.Collections.Generic;

namespace Task2
{
    public class MyDynamicArray<T> : IEnumerable, IEnumerable<T>
    {
        private T[] myArray;
        private int size;
        private int count;
        public MyDynamicArray()
        {
            count = 8;
            this.myArray = new T[count];

        }
       
        public MyDynamicArray(int capacity)
        {
            myArray = new T[capacity];

        }
        
        public MyDynamicArray(IEnumerable<T> source)
        {
            myArray = new T[(source as ICollection).Count];
            (source as ICollection).CopyTo(myArray, 0);
            size = myArray.Length;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                yield return myArray[i];

                if (i == 5)
                    yield break;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return myArray.GetEnumerator();
        }

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

        public void AddRange(T[] elements)
        {
            if ((size == count) || ((count - size) <= elements.Length))
            {
                Array.Resize<T>(ref myArray, myArray.Length + elements.Length);

            }
            Array.Copy(elements, 0, myArray, count, elements.Length);
        }
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
        
        public int Capacity()
        {
            count = myArray.Length;
            return count;
        }

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
