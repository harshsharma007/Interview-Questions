using System;
using System.Collections.Generic;

namespace ClearTest
{
    class MinStack
    {
        public Stack<int> stack;
        public int minimumElement;

        public MinStack()
        {
            stack = new Stack<int>();
        }

        public void getMin()
        {
            if (stack.Count == 0)
                Console.WriteLine("Stack is empty");
            else
                Console.WriteLine("Minimum Element in the " + " stack is: " + minimumElement);
        }

        public void Peek()
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            int t = (int)stack.Peek();
            Console.Write("Top Most Element is: ");

            if (t < minimumElement)
                Console.WriteLine(minimumElement);
            else
                Console.WriteLine(t);
        }

        public void Pop()
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Console.Write("Top Most Element Removed: ");
            int t = (int)stack.Pop();

            if (t < minimumElement)
            {
                Console.WriteLine(minimumElement);
                minimumElement = 2 * minimumElement - t;
            }
            else
                Console.WriteLine(t);
        }

        public void Push(int x)
        {
            if (stack.Count == 0)
            {
                minimumElement = x;
                stack.Push(x);
                Console.WriteLine("Number Inserted: " + x);
                return;
            }

            if (x < minimumElement)
            {
                stack.Push(2 * x - minimumElement);
                minimumElement = x;
            }
            else
                stack.Push(x);

            Console.WriteLine("Number Inserted: " + x);
        }
    }
}
