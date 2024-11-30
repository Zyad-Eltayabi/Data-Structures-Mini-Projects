namespace DoublyLinkedList
{
    public class Node<T>
    {
        public T value;
        public Node<T> next;
        public Node<T> prev;

        public Node(T value)
        {
            this.value = value;
            next = prev = null;
        }
    }

    public class MyDoublyLinkedList<T>
    {

        public Node<T> head = null;
        private int _size = 0;
        public void InsertAtFront(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (head == null)
            {
                head = newNode;
                _size++;
                return;
            }

            Node<T> firstNode = head;
            firstNode.prev = newNode;
            newNode.next = firstNode;
            newNode.prev = null;
            head = newNode;
            _size++;
        }

        public void Print()
        {
            Node<T> current = head;
            Console.WriteLine("_________________________");
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }

        public Node<T> Find(T value)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.value.Equals(value))
                    return current;
                current = current.next;
            }
            return null;
        }

        public void InsertAfter(Node<T> prevNode, T newNodeValue)
        {
            if (prevNode == null)
                return;

            Node<T> newNode = new Node<T>(newNodeValue);
            newNode.next = prevNode.next;
            newNode.prev = prevNode;

            if (prevNode.next != null)
                prevNode.next.prev = newNode;

            prevNode.next = newNode;
            _size++;
        }

        public void InsertAtEnd(T value)
        {
            _size++;
            Node<T> newNode = new Node<T>(value);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node<T> lastNode = head;
            while (lastNode.next != null)
            {
                lastNode = lastNode.next;
            }

            lastNode.next = newNode;
            newNode.prev = lastNode;
        }

        public void DeleteNode(Node<T> deletedNode)
        {
            if (deletedNode == null || head == null)
                return;

            _size--;
            if (deletedNode.prev != null && deletedNode.next != null)
            {
                deletedNode.prev.next = deletedNode.next;
                deletedNode.next.prev = deletedNode.prev;
                return;
            }

            // case if the node to delete is the last node
            if (deletedNode.next == null)
            {
                deletedNode.prev.next = null;
                deletedNode.prev = null;
                return;
            }

            // case if the node to delete is the first node
            if (deletedNode.prev == null)
            {
                deletedNode.next.prev = null;
                head = deletedNode.next;
                deletedNode.next = null;
                return;
            }
        }

        public void DeleteFirstNode()
        {
            if (head == null)
                return;

            _size--;

            Node<T> current = head;

            if (current.next != null)
                current.next.prev = null;

            head = current.next;

            current.next = null;

        }

        public void DeleteLastNode()
        {
            if (head == null)
                return;

            _size--;

            Node<T> current = head;
            while (current.next != null)
            {
                current = current.next;
            }

            if (current.prev != null)
                current.prev.next = null;
            else
                head = null;

        }

        public int Size() => _size;
        
        public bool IsEmpty() => _size == 0;
    }



}
