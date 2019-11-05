using System;
namespace stackImplementation
{
    class Stack
    {
        private int[] arr;
        private int head;

        public Stack(int size)
        {
            arr = new int[size];
            head = 0;
        }

        public void push(int item)
        {
            if(head > arr.Length -1)
            {
                Console.WriteLine("Error: OverFlow");
                Environment.Exit(1);
            }
            arr[head] = item;
            head++;
        }

        public int pop()
        {
            head--;
            if(head < 0)
            {
                Console.WriteLine("Error: UnderFlow");
                Environment.Exit(1);
            }
            return arr[head];
        }

        public int peek()
        {
            if(head <= 0)
            {
                Console.WriteLine("Error: UnderFlow");
                Environment.Exit(1);
            }
            return arr[head - 1];
        }

        public void printStack()
        {
            while(head > 0)
            {
                Console.WriteLine(arr[head - 1]);
                head--;
            }
        }

        public int size()
        {
            return head;
        }
    }
}