using System;
using StackMain;

namespace StackMain
{
    public class CheckBalancedParentheses
    {
        public static bool isParenthesesMatching(char par1, char par2)
        {
            if (par1 == '{' && par2 == '}')
                return true;
            else if (par1 == '[' && par2 == ']')
                return true;
            else if (par1 == '(' && par2 == ')')
                return true;
            else
                return false;
        }

        public static bool isExpressionValid(char[] array)
        {
            StackOperations stack = new StackOperations(array.Length);
            foreach (var item in array)
            {
                if (item == '{' || item == '[' || item == '(')
                    stack.Push(item);
                else
                {
                    if (stack.IsEmpty())
                        return false;
                    if (!isParenthesesMatching(Convert.ToChar(stack.Pop()), item))
                        return false;
                }

            }
            if (stack.IsEmpty())
                return true;
            else
                return false;
        }
    }
}
