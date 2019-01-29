using System;
namespace StackMain
{
    public class GetMinimumInStack
    {
        StackOperations stack;
        int minElement;
        public GetMinimumInStack()
        {
            stack = new StackOperations(100);
        }

        public void Push(int x)
        {
            if (stack.IsEmpty())
            {
                minElement = x;
                stack.Push(x);
            }
            else if (x < minElement)
                minElement = x;
            else
                stack.Push(x);
        }

        public void Min()
        {
            Console.WriteLine("Minimum is" + minElement);
        }
    }
}
