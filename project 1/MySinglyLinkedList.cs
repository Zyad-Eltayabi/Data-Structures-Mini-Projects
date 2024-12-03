namespace ConsoleApp1
{
    public class MySinglyLinkedList
    {
        public class Node
        {
            public Node next;
            public int value;
        }

        public Node? head = null;

        public Node FindNode(int value)
        {
            Node copyHead = head;
            while (copyHead != null)
            {
                if (copyHead.value == value)
                {
                    return copyHead;
                }
                copyHead = copyHead.next;
            }
            return null;
        }

        public void InsertAfter(Node prevNode, int value)
        {
            if (prevNode == null)
            {
                Console.WriteLine("prev node can not be null");
                return;
            }
            Node newNode = new Node();
            newNode.value = value;

            newNode.next = prevNode.next;
            prevNode.next = newNode;
        }

        public void InsertAtEnd(int value)
        {
            Node newNode = new Node();
            newNode.value = value;
            newNode.next = null;

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node lastNode = head;
            while (lastNode.next != null)
            {
                lastNode = lastNode.next;
            }

            lastNode.next = newNode;
        }
        public void InsertAtFront(int value)
        {
            Node newNode = new Node();
            newNode.value = value;
            newNode.next = head;
            head = newNode;
        }
        public void DeleteNode(int value)
        {

            if (head == null)
                return;

            if (head.value == value)
            {
                head = head.next;
                return;
            }

            Node currentNode = head;
            Node prevNode = head;

            while (currentNode != null && currentNode.value != value)
            {
                prevNode = currentNode;
                currentNode = currentNode.next;
            }

            // if the value is not found 
            if (currentNode == null)
                return;

            prevNode.next = currentNode.next;


        }
        public void PrintValues()
        {
            Console.WriteLine("_______________________________________");
            Node copyHead = head;
            while (copyHead != null)
            {
                Console.WriteLine(copyHead.value);
                copyHead = copyHead.next;
            }
        }

        public void DeleteFirstNode()
        {
            if (head == null)
                return;

            head = head.next;
        }

        public void DeleteLastNode()
        {
            if (head == null)
                return;

            if (head.next == null)
                head = null;

            Node copyHead = head;
            Node prevNode = null;

            while (copyHead.next != null)
            {
                prevNode = copyHead;
                copyHead = copyHead.next;
            }

            prevNode.next = null;
        }
    }

}
