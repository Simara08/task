using System;
using System.Collections.Generic;
using System.Text;

namespace EasyMoney
{
    public class Mylistt<T>
    {
        
        private static int count;
        public int Count { 
            get
            {
                return count;
            } 
            set
            {
                if (value>0)
                {
                    value = count;
                }
                Console.WriteLine("Count'u duzgun daxil edin");
            }
        }
        public int Capacity = 0;
        public T[] array; 
        public Mylistt()
        {
            array = new T[0];
        }
        public bool Isex=false;
        public Mylistt(int capacity)
        {
            if (Capacity>0)
            {
                Capacity = capacity;
                Isex = true;
            }
           
        }
        public void Additem(T item)
        {
            Resizeble(array.Length == count);
                array[count] = item;
            count++;
        }
        public void AddItem(params T[] items)
        {
           
            foreach (var item in items)
            {
                Additem(item);
            }
        }
        public void Resizeble(bool value)
        {
            if (value)
            {
                if (array.Length>0)
                {
                  Array.Resize(ref array, array.Length * 2);
                }
                else
                {
                    Array.Resize(ref array, array.Length + 2);
                }
            }
        }

    }
}
