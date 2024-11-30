using DoublyLinkedList;

namespace Data_Structures_Mini_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test doubly linked list
            MyDoublyLinkedList<int> myDoublyLinkedList = new MyDoublyLinkedList<int>();
            myDoublyLinkedList.InsertAtFront(5);
            myDoublyLinkedList.InsertAtFront(4);
            myDoublyLinkedList.InsertAtFront(3);
            myDoublyLinkedList.InsertAtFront(2);
            myDoublyLinkedList.InsertAtFront(1);

            Console.WriteLine("Linked List Content");
            myDoublyLinkedList.Print();

         
            Console.WriteLine($"The number of items = {myDoublyLinkedList.Size()}");

            myDoublyLinkedList.Clear();

            Console.WriteLine($"The number of items after exec clear method = {myDoublyLinkedList.Size()}");

        }
    }
}
