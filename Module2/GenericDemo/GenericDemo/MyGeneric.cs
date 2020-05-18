using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GenericDemo
{
    class MyGeneric<T>
    {
        private T[] list = new T[0];

        public int Count => list.Length;
        public T this[int index]
        {
            get
            {
                T temp = default(T);
                if(index >=0 && index < list.Length)
                {
                    temp = list[index];
                }

                return temp;
            }
            set
            {
                if (index >= 0 && index < list.Length)
                {
                    Array.Resize(ref list, list.Length + 1);
                    list[list.Length - 1] = value;
                }
            }
        }

        public void Add(T item)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = item;
        }
    }
}
