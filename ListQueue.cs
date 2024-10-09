using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;

namespace HW1
{
    public class ListQueue<T>
    {
        public List<T> elements = new List<T>();

        public void Enqueue(T item)
        {
            elements.Add(item);
        }
        
        public T Dequeue()
        {
            if(elements.Count == 0)
            {
                throw new IndexOutOfRangeException("Queue is empty!");
            }
            T front = elements[0];
            elements.RemoveAt(0);
            return front;
        }

        public T Peek ()
        {
            if (elements.Count == 0)
            {
                throw new IndexOutOfRangeException("Queue is empty!");
            }
            return elements[0];
        }
        public int Count => elements.Count;
        public bool IsEmpty => elements.Count == 0;
        
        public void printqueue()
        {
            foreach (T item in elements) 
                Console.WriteLine(item);
        }
    }

}

