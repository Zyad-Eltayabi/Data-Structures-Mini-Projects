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
        }
    }
}
