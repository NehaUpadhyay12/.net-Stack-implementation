using System;
namespace StackMain
{
    public class TwoStacksInArray
    {
        int top1, top2;
        int[] array;

        public TwoStacksInArray(int[] array)
        {
            this.array = array;
            top1 = -1;
            top2 = array.Length;
        }

        public void Push1(int element)
        {
            if (top1 < top2 - 1)
            {
                top1++;
                array[top1] = element;
            }
            else
                Console.WriteLine("Stack 1 is full");
        }
        public void Push2(int element)
        {
            if (top1 < top2 - 1)
            {
                top2--;
                array[top2] = element;
            }
            else
                Console.WriteLine("Stack 2 is full");
        }
        public int Pop1()
        {
            if (top1 > -1)
            {
                int poppedElement;
                poppedElement = array[top1];
                top1--;
                return poppedElement;
            }
            else
            {
                Console.WriteLine("Stack 1 is empty");
                return 0;
            }

        }
        public int Pop2()
        {
            if (top2 < array.Length)
            {
                int poppedElement;
                poppedElement = array[top2];
                top2++;
                return poppedElement;
            }
            else
            {
                Console.WriteLine("Stack 2 is empty");
                return 0;
            }

        }
    }
}
