using System;

namespace OOPS
{
    class CustomStack<T>
    {
        private T[] arr;
        private int size;
        private int top;

        public CustomStack(int capacity = 6)
        {
            arr = new T[capacity];
            size = capacity;
            top = -1;
        }

        public void Push(T item)
        {
            if (top == size - 1)
                throw new InvalidOperationException("Stack is FULL");

            arr[++top] = item;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            return arr[top--];
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            return arr[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public void Print()
        {
            for (int i = top; i >= 0; i--)
                Console.Write(arr[i] + " ");
            
            Console.WriteLine();
        }
    }

    class Program1
    {
        public void Run()   // FIXED: Removed static
        {
            CustomStack<int> st = new CustomStack<int>(5);

            st.Push(10);
            st.Push(20);
            st.Push(30);

            st.Print();      // Output: 30 20 10

            Console.WriteLine(st.Pop());   // 30
            Console.WriteLine(st.Peek());  // 20

            st.Print();      // Output: 20 10
        }
    }
}