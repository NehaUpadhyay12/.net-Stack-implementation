using System;

namespace StackMain
{
    public class MainClass
    {
        //public static void Main(string[] args)
        //{
        //    StackOperations obj = new StackOperations();

        //    Console.WriteLine("Enter the number against your choice of operation");
        //    Console.WriteLine("1 - Push \n2 - Pop \n3 - Peek \n4 - IsFull \n5 - IsEmpty \n6 - Show Content \n7 - Stop Execution");
        //    int choice = Convert.ToInt32(Console.ReadLine());

        //    while(choice!=7){
        //        switch (choice)
        //        {
        //            case 1:
        //                Console.WriteLine("Enter the element you want to insert");
        //                int ele = Convert.ToInt32(Console.ReadLine());
        //                obj.Push(ele);
        //                Console.WriteLine("Enter choice again");
        //                choice = Convert.ToInt32(Console.ReadLine());
        //                break;
        //            case 2:
        //                obj.Pop();
        //                Console.WriteLine("Enter choice again");
        //                choice = Convert.ToInt32(Console.ReadLine());
        //                break;
        //            case 3:
        //                obj.Peek();
        //                Console.WriteLine("Enter choice again");
        //                choice = Convert.ToInt32(Console.ReadLine());
        //                break;
        //            case 4:
        //                bool ret = obj.IsFull();
        //                if (ret)
        //                    Console.WriteLine("Yes");
        //                else
        //                    Console.WriteLine("No");
        //                Console.WriteLine("Enter choice again");
        //                choice = Convert.ToInt32(Console.ReadLine());
        //                break;
        //            case 5:
        //                bool retVal = obj.IsEmpty();
        //                if (retVal)
        //                    Console.WriteLine("Yes");
        //                else
        //                    Console.WriteLine("No");
        //                Console.WriteLine("Enter choice again");
        //                choice = Convert.ToInt32(Console.ReadLine());
        //                break;
        //            case 6:
        //                obj.Traverse();
        //                Console.WriteLine("Enter choice again");
        //                choice = Convert.ToInt32(Console.ReadLine());
        //                break;
        //            case 7:
        //                break;
        //            default:
        //                break;
        //        }
        //    }

        //}
    }

    public class StackOperations
    {
        int top = -1;
        Object[] Stack;
        int elementCount;

        public StackOperations(int elementCount)
        {
            this.elementCount = elementCount;
            Stack = new Object[elementCount];
        }

        public void Push(object element){
            if (IsFull())
                Console.WriteLine("Stack is Full!");
            else{
                top++;
                Stack[top] = element;
                //Traverse();
            }
                
        }

        public object Pop(){
            if (IsEmpty()){
                Console.WriteLine("Stack is empty");
                return null;
            }
            else{
                Object poppedElement = Stack[top];
                top--;
                //Console.WriteLine("Popped element is " + poppedElement.ToString());
                //Traverse();
                return poppedElement;
            }
        }

        public Object Peek(){
            if (IsEmpty()){
                Console.WriteLine("Stack is empty");
                return null;
            }
            else
            {
                return Stack[top];
            }
        }

        public bool IsFull(){
            if (top == elementCount-1)
                return true;
            else
                return false;
        }

        public bool IsEmpty(){
            if (top == -1)
                return true;
            else
                return false;
        }

        public void Traverse(){
            if (IsEmpty())
                Console.WriteLine("Stack is empty.");
            else{
                Console.WriteLine("Your stack is:");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(Stack[i]);
                }
            }

        }
    }
}
