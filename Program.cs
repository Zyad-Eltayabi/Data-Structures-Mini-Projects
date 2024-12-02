using Data_Structures_Mini_Projects.project_2;
using DoublyLinkedList;

namespace Data_Structures_Mini_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test My Queue 

            MyQueue<int> myQueue = new MyQueue<int>();

            myQueue.Push(10);
            myQueue.Push(20);
            myQueue.Push(30);
            myQueue.Push(40);
            myQueue.Push(50);

            Console.WriteLine("\nPrint Queue Items");
            myQueue.Print();

            myQueue.Pop();
            Console.WriteLine("\nQueue after pop");
            myQueue.Print();

            Console.WriteLine($"Queue size = {myQueue.Size()}");
            Console.WriteLine($"Queue front = {myQueue.Front()}");
            Console.WriteLine($"Queue back = {myQueue.Back()}");

            Console.WriteLine("______________________________________________________________");

            // # Extension 1
            Console.WriteLine("\n Item (2) = {0}", myQueue.GetItem(2));

            // # Extension 2
            myQueue.Reverse();
            Console.WriteLine("\nQueue after reverse");
            myQueue.Print();

            // # Extension 3
            myQueue.UpdateItem(2, 600);
            Console.WriteLine("\nQueue after update item 2");
            myQueue.Print();

            // # Extension 4
            myQueue.InsertAfter(2, 800);
            Console.WriteLine("\nQueue after insert 800 after item(2) ");
            myQueue.Print();

            // # Extension 5
            myQueue.InsertAtFront(1000);
            Console.WriteLine("\nQueue after insert 1000 at front ");
            myQueue.Print();

            // # Extension 6
            myQueue.InsertAtEnd(2000);
            Console.WriteLine("\nQueue after insert 2000 at end ");
            myQueue.Print();

            // # Extension 7
            myQueue.Clear();
            Console.WriteLine("\nQueue after Clear() ");
            myQueue.Print();
        }
    }
}
