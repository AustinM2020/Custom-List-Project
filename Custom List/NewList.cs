using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_List
{
    public class NewList<T>
    {
        int count;
        public int Count { get { return count; } set { count = value; } }
        int capacity;
        public int Capacity { get { return capacity; } set { capacity = value; } }
        int index;
        public int Index { get { return index; } set { index = value; } } 
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
            if (index == capacity)
            {
                SwapArrays();
            }
            items[Index] = itemToAdd;
            index++;
            count++;          
        }
        private void SwapArrays()
        {
            T[] tempArr = new T[capacity];
            tempArr = items;
            capacity = capacity * 2;
            T[] items2 = new T[capacity];
            items = items2;
            items2 = tempArr;
            for (int i = 0; i < (capacity / 2); i++)
            {
                items[i] = items2[i];
            }
        }
        public void Remove(T itemToRemove)
        {
            for (int i = 0; i < capacity; i++)
            {
                if(itemToRemove.Equals(items[i]))
                {

                }
            }
        }
    }
}
