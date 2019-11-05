using System;

namespace stackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack1 = new Stack(5);

            stack1.push(2);
            stack1.push(4);
            stack1.push(8);
            stack1.push(7);

            Console.WriteLine("Stack size is " + stack1.size());
            Console.WriteLine("Value at top of stack is " + stack1.peek());

            stack1.printStack();
            stack1.pop();
            //next statement should be unreachable due to out of bounds exception
            Console.WriteLine("unreachable statement");


        }
    }
}
