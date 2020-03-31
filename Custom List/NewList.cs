using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_List
{
    public class NewList<T>
    {
        int count;
        public int Count { get; set; }
        int capacity;
        public int Capacity { get; set; }
        int index;
        public int Index { get; set; }
        private T[] items;
        
        public NewList()
        {
            capacity = 4;
            items = new T[capacity];
        }
        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }
        public void Add(T itemToAdd)
        {
            if (Index == capacity)
            {               
                T[] tempArr = new T[capacity];
                T[] items2 = new T[capacity * 2];
                tempArr = items;
            }
            items[Index] = itemToAdd;
            Index++;
            Count++;
           
        }
    }
}
