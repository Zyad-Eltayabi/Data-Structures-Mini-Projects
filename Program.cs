using DoublyLinkedList;

namespace Data_Structures_Mini_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test doubly linked list
            MyDoublyLinkedList<int> myDoublyLinkedList = new MyDoublyLinkedList<int>();

            if (myDoublyLinkedList.IsEmpty())
                Console.WriteLine("yes, the linked list is empty");

            myDoublyLinkedList.InsertAtFront(5);
            myDoublyLinkedList.InsertAtFront(4);
            myDoublyLinkedList.InsertAtFront(3);
            myDoublyLinkedList.InsertAtFront(2);
            myDoublyLinkedList.InsertAtFront(1);

            Console.WriteLine("Linked List Content");
            myDoublyLinkedList.Print();


            if (myDoublyLinkedList.IsEmpty())
                Console.WriteLine("yes, the linked list is empty");
            else
                Console.WriteLine($"Linked list is not empty and the number of items = {myDoublyLinkedList.Size()}");
        }
    }
}
