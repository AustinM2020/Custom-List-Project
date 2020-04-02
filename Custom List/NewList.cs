using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Custom_List
{
    public class NewList<T> : IEnumerable
    {
        int count;
        public int Count { get { return count; } set { count = value; } }
        int capacity;
        public int Capacity { get { return capacity; } set { capacity = value; } }
        int index;
        private T[] items;
        public int startingIndex;

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
            count++;           
            if (count == capacity)
            {
                SwapArrays();
            }
            items[index] = itemToAdd;
            index++;
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
        public bool Remove(T itemToRemove)
        {
            for (int i = 0; i < (capacity - 1); i++)
            {
                startingIndex = i;
                if (itemToRemove.Equals(items[i]))
                {
                    ReassignIndexes();
                    count--;
                    index--;
                    return true;
                }
            }
            return false;
        }
        private void ReassignIndexes()
        {
            for (int i = startingIndex; i < capacity; i++)
            {
                if (i == (capacity - 1))
                {
                    items[i] = default(T);
                }
                else
                {
                    items[i] = items[i + 1];
                }
            }
        }
        public override string ToString()
        {
            string str = null;
            for (int i = 0; i < count; i++)
            {
                if(i == count - 1)
                {
                    str += items[i];
                }
                else
                {
                    str += items[i] + ", ";
                }
            }
            return str;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }
        public static NewList<T> operator +(NewList<T> l1, NewList<T> l2)
        {
            NewList<T> list3 = new NewList<T>();
            for (int i = 0; i < l1.count; i++)
            {
                list3.Add(l1[i]);
            }
            for (int i = 0; i < l2.count; i++)
            {
                list3.Add(l2[i]);
            }
            return list3;     
        }
        public NewList<T> Zip(NewList<T> l2)
        {
            NewList<T> list3 = new NewList<T>();
            int index1 = 0;
            int index2 = 0;
            for (int i = 1; i <= (count + l2.count); i++)
            { 
                if(((i % 2) == 0) && index2 < l2.count)
                {
                    list3.Add(l2[index2]);
                    index2++;
                }
                else if(((i % 2) > 0) && index1 < count)
                {
                    list3.Add(items[index1]);
                    index1++;
                }
                else
                {
                    if(index2 < l2.count)
                    {
                        for (int j = index2; j < l2.count; j++)
                        {
                            list3.Add(l2[j]);
                        }
                    }
                    else if(index1 < count)
                    {
                        for (int j = index1; j < count; j++)
                        {
                            list3.Add(items[j]);
                        }
                    }
                    break;
                }
            }
            return list3;
        }
        public static NewList<T> operator -(NewList<T> l1, NewList<T> l2)
        {
            NewList<T> list3 = new NewList<T>();
            for (int i = 0; i < l1.count; i++)
            {
                list3.Add(l1[i]);
            }
            for (int i = 0; i < l1.count; i++)
            {
                for (int j = 0; j < l2.count; j++)
                {
                    if (list3[i].Equals(l2[j]))
                    {
                        list3.Remove(list3[i]);
                        i = -1;
                        break;
                    }
                }
            }
            return list3;
        }
    }
}
