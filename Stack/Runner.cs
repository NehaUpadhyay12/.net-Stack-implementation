using System;
namespace StackMain
{
    public class Runner
    {
        public static void Main(string[] args)
        {
            //char[] expression = { '{', '(', ')', '}', '[', ']', '}' };
            //Console.WriteLine(CheckBalancedParentheses.isExpressionValid(expression));

            //int[] array = new int[5];
            //TwoStacksInArray ts = new TwoStacksInArray(array);
            //ts.Push1(5);
            //ts.Push2(10);
            //ts.Push2(15);
            //ts.Push1(11);
            //ts.Push2(7);
            //Console.WriteLine("Popped element from" +
            //                  " stack1 is " + ts.Pop1());
            //ts.Push2(40);
            //Console.WriteLine("Popped element from" +
            //" stack2 is " + ts.Pop2());

            GetMinimumInStack stack = new GetMinimumInStack();
            stack.Push(16);
            stack.Push(15);
            stack.Push(29);
            stack.Push(19);
            stack.Push(18);
            stack.Min();
            stack.Push(11);
            stack.Min();
        }
    }
}
