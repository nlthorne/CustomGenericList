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
        //T value;
        private int count = 10;
        string toString;
        public T[] array;
        public int Count
        {
            get
            {
                return Count;
            }
            set
            {
                count = value;
            }
        }
        public GenericList()
        {
            array = new T[Count];
        }
        public IEnumerable GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i]; 
            }
        }
        public void AddObject(T itemToAdd)
        {
            count++;
        }
        public void RemoveObject(T itemToRemove)
        {
            count--;
        }
        public override string ToString()
        {
            for (int i = 0; i < array.Length; i++)
            {
                toString += array[i].ToString();
            }
            return toString;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }
    }

}
