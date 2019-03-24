using System;
using System.Collections;

namespace MinInStack
{
    public class StackOperations
    {
        Stack mainStack = new Stack();
        Stack minElementStack = new Stack();

        public void Push(int data)
        {
            if (data < Min())
                minElementStack.Push(data);
            mainStack.Push(data);
        }

        public int Pop()
        {
            int retValue = (int)mainStack.Pop();
            if (retValue == Min())
                minElementStack.Pop();
            return retValue;
        }

        public int Min()
        {
            if (minElementStack.Count == 0)
                return int.MaxValue;
            else
                return (int)minElementStack.Peek();
        }

    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            StackOperations s = new StackOperations();
            s.Push(50);
            s.Push(40);
            s.Push(20);
            s.Push(60);
            Console.WriteLine($"Minimum in stack is {s.Min()}");
            s.Push(10);
            s.Push(5);
            Console.WriteLine($"Minimum in stack is {s.Min()}");
            s.Pop();
            Console.WriteLine($"Minimum in stack is {s.Min()}");
            s.Pop();
            Console.WriteLine($"Minimum in stack is {s.Min()}");
            s.Pop();
            Console.WriteLine($"Minimum in stack is {s.Min()}");
        }
    }


}
