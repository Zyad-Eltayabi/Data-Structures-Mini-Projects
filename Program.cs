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

            // searching for the node
            DoublyLinkedList.Node<int> findNode = myDoublyLinkedList.Find(2);
            if (findNode != null)
                Console.WriteLine("node with value 2 is found :-) ");
            else
                Console.WriteLine("node with value 2 is not found :-(");

            myDoublyLinkedList.InsertAfter(findNode, 500);
            Console.WriteLine("after insert 500 after 2 :");
            myDoublyLinkedList.Print();

            myDoublyLinkedList.InsertAtEnd( 700);
            Console.WriteLine("after insert 700 at end :");
            myDoublyLinkedList.Print();

            DoublyLinkedList.Node<int> findNode4 = myDoublyLinkedList.Find(4);
            myDoublyLinkedList.DeleteNode(findNode4);
            Console.WriteLine("after deleting node with value 4 :");
            myDoublyLinkedList.Print();

            myDoublyLinkedList.DeleteFirstNode();
            Console.WriteLine("after deleting first node :");
            myDoublyLinkedList.Print();

            myDoublyLinkedList.DeleteLastNode();
            Console.WriteLine("\nafter deleting last node :");
            myDoublyLinkedList.Print();
        }
    }
}
