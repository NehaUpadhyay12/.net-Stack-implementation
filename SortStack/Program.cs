using System;
using System.Collections;
using System.Collections.Generic;

namespace SortStack
{
    class MainClass
    {
        public static Stack<int> Sort(Stack<int> s1)
        {
            Stack<int> s2 = new Stack<int>();
            while (s1.Count!=0)
            {
                int temp = s1.Pop();
               
                    while (s2.Count != 0 && temp < s2.Peek())
                    {
                        s1.Push(s2.Pop());
                    }
                s2.Push(temp);
            }

            return s2;
        }
        public static void Main(string[] args)
        {
            Stack<int> s1 = new Stack<int>();
            s1.Push(3);
            s1.Push(1);
            s1.Push(11);
            s1.Push(10);
            s1.Push(12);

            Stack<int> s2 = Sort(s1);
        }
    }
}
