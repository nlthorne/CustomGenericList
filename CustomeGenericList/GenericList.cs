using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomeGenericList
{
    public class GenericList <T> : IEnumerable
    {
        private int count = 0;
        private string toString;
        public T[] array;
        public int Count
        {
            get
            {
                return count;
            }
            
        }
        public GenericList()
        {
            array = new T[0];
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i]; 
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }
        public void AddObject(T itemToAdd)
        {
            T[] tempArray = new T[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[tempArray.Length - 1] = itemToAdd;
            array = tempArray;
            array[count] = itemToAdd;
            count++;
           
        }
        public void RemoveObject(T itemToRemove)
        {
            T[] tempArray = new T[array.Length - 1];
            int x = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {

                if (EqualityComparer<T>.Default.Equals(array[i], itemToRemove))
                {
                    continue;
                }
                else
                {
                    tempArray[x] = array[i];
                    x++;
                }
            }
            array = tempArray;
            count--;
        }
        public override string ToString()
        {
            for (int i = 0; i < count; i++)
            {
                toString += array[i] + " ";
            }
            return toString;
        }


        public static GenericList<T> operator +(GenericList<T> listOne, GenericList<T> listTwo)
        {

            GenericList<T> addedList = new GenericList<T>();
            
            foreach (T item in listOne)
            {
                addedList.AddObject(item);
            }
            foreach (T item in listTwo)
            {
                addedList.AddObject(item);
            }
            //Console.WriteLine("Testing:");
            return addedList;
        }

        public static GenericList<T> operator -(GenericList<T> listOne, GenericList<T> listTwo)
        {

            foreach (T item in listTwo)
            {
                listOne.RemoveObject(item);
            }

            return listOne;
        }
        //private void EnsureCapacity(int min)
        //{
        //    if (array.Length < min)
        //    {
        //        int newCapacity = array.Length == 0 ? count : array.Length * 2;
        //        if ((uint)newCapacity > array.MaxArrayLength) newCapacity = array.MaxArrayLength;
        //        if (newCapacity < min) newCapacity = min;
        //        Capacity = newCapacity;
        //    }
        //}
        public GenericList<T> Zipped(GenericList<T> list1, GenericList<T> list2)
        {
            GenericList<T> zippedResult = new GenericList<T>();

            for (int i = 0; i < array.Length + 3; i++)

            {
                zippedResult.AddObject(list1.array[i]);
                zippedResult.AddObject(list2.array[i]);
            }

            return zippedResult;
        }


    }

}
