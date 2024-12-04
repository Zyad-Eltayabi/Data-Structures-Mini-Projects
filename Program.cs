using Data_Structures_Mini_Projects.project_2;
using Data_Structures_Mini_Projects.project_3;
using Data_Structures_Mini_Projects.project_4;
using Data_Structures_Mini_Projects.project_6;
using Data_Structures_Mini_Projects.project_7;


namespace Data_Structures_Mini_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test My Stack 

            MyStackArr<int> myStack = new MyStackArr<int>();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.Push(50);


            Console.WriteLine("\nPrint Stack Items");
            myStack.Print();

            myStack.Pop();
            Console.WriteLine("\nStack after pop");
            myStack.Print();

            Console.WriteLine($"Stack size = {myStack.Size()}");
            Console.WriteLine($"Stack front = {myStack.Top()}");
            Console.WriteLine($"Stack back = {myStack.Bottom()}");

            Console.WriteLine("______________________________________________________________");

            // # Extension 1
            Console.WriteLine("\n Item (2) = {0}", myStack.GetItem(2));

            // # Extension 2
            myStack.Reverse();
            Console.WriteLine("\nStack after reverse");
            myStack.Print();

            // # Extension 3
            myStack.UpdateItem(2, 600);
            Console.WriteLine("\nStack after update item 2");
            myStack.Print();

            // # Extension 4
            myStack.InsertAfter(2, 800);
            Console.WriteLine("\nStack after insert 800 after item(2) ");
            myStack.Print();

            // # Extension 5
            myStack.InsertAtFront(1000);
            Console.WriteLine("\nStack after insert 1000 at front ");
            myStack.Print();

            // # Extension 6
            myStack.InsertAtEnd(2000);
            Console.WriteLine("\nStack after insert 2000 at end ");
            myStack.Print();

            // # Extension 7
            myStack.Clear();
            Console.WriteLine("\nStack after Clear() ");
            myStack.Print();

        }
    }
}
