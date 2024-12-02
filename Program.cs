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

            Console.WriteLine("\nLinked List Content");
            myDoublyLinkedList.Print();

            Node<int> getNode = myDoublyLinkedList.GetNode(-1);
            if(getNode != null )
            {
                Console.WriteLine($"Node value = {getNode.value} "); 
            }
            else
            {
                Console.WriteLine("Node is not found");
            }

         

        }
    }
}
