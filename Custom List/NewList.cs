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
        private T[] items;

        public NewList()
        {
            capacity = 4;
            items = new T[capacity];
        }
        public void Add(T itemToAdd)
        {
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = itemToAdd;
            }
        }
    }
}
