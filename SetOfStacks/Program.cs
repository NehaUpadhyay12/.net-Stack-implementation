using System;
using System.Collections;
using System.Collections.Generic;

namespace SetOfStacks
{
    class SetOfStacks
    {
        int capacity;
        List<Stack> superStack;
        Stack subStack = null;
        public SetOfStacks(int capacity)
        {
            this.capacity = capacity;
            superStack = new List<Stack>();
        }

        public void Push(int data)
        {
            if (superStack.Count == 0 || subStack.Count == capacity)
            {
                subStack = new Stack(capacity);
                subStack.Push(data);
                superStack.Add(subStack);
            }
            else if (subStack.Count < capacity)
            {
                subStack.Push(data);
            }
        }

        public int Pop()
        {
            int retVal = -1;
            if (superStack.Count != 0)
            {
                Stack s = superStack[superStack.Count - 1];

                retVal = (int)s.Pop();
                if (s.Count == 0)
                {
                    superStack.Remove(s);
                    subStack = superStack[superStack.Count - 1];
                }

            }
            else
                Console.WriteLine("Stack is empty");
            return retVal;
        }

        public int PopAt(int index)
        {
            int retVal = -1;
            if (superStack.Count != 0)
            {
                Stack s = superStack[index];
                retVal = (int)s.Pop();

                if (s.Count == 0)
                {
                    superStack.Remove(s);
                    subStack = superStack[superStack.Count - 1];
                }

                else
                {
                    for (int i = index + 1; i < superStack.Count; i++)
                    {
                        Stack currentStack = superStack[i];
                        int poppedElement = (int)currentStack.Pop();
                        if (currentStack.Count == 0)
                            superStack.Remove(currentStack);
                        Stack prevStack = superStack[i - 1];
                        prevStack.Push(poppedElement);
                    }
                }
            }
            return retVal;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            SetOfStacks obj = new SetOfStacks(5);
            obj.Push(1);
            obj.Push(2);
            obj.Push(3);
            obj.Push(4);
            obj.Push(5);
            obj.Push(6);
            obj.Push(7);
            obj.Push(8);
            obj.Pop();
            obj.Push(8);
            obj.Push(9);
            obj.Push(10);
            obj.Push(11);
            obj.Pop();
            obj.Push(11);
            obj.Push(12);
            obj.Push(13);

            obj.PopAt(0);
            obj.PopAt(2);
            obj.PopAt(1);
            obj.PopAt(1);
        }
    }
}
