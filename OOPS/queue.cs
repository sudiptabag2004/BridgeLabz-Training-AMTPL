using  System;
using System.Collections.Generic;

namespace OOPS
{

    public class CustomQueue<T>
    {
        private T[] arr;
        private int size;
        private int count;
        private int front;
        private int rear;

        CustomQueue(int capacity = 6)
        {
            arr = new T[capacity];
            count = 0;
            front = 0;
            rear = -1;
            size = capacity;
        }

        public void enqueue(T item)
        {
            if (count == size)
            {
                throw new InvalidOperationException();
            }
        }

    }
};

