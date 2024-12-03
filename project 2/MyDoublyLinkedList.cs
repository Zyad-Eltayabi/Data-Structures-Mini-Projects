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
            current.prev = null;
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

        public void Clear()
        {
            while (_size > 0)
            {
                DeleteFirstNode();
            }
        }

        public void Reverse()
        {
            if (_size == 0)
                return;

            // ==> old solution 
            /* T[] headValue = new T[_size];
             int counter = _size - 1;
             while (_size > 0)
             {
                 headValue[counter--] = head.value;
                 DeleteFirstNode();
             }
             for(int i = 0; i < headValue.Length; i++)
                 InsertAtEnd(headValue[i]);*/

            Node<T> current = head;
            Node<T> temp = null; // temp node to store the previous node in the current node
            while (current != null)
            {
                temp = current.prev;
                // swap the prev node and the next node
                current.prev = current.next;
                current.next = temp;
                current = current.prev;
            }

            if (temp != null) // move the head 
                head = temp.prev;
        }

        public Node<T> GetNode(int index)
        {
            if (head == null || index < 0 || index >= _size)
                return null;

            int counter = 0;
            Node<T> current = head;
            while (current != null)
            {
                if (counter == index)
                    break;
                counter++;
                current = current.next;
            }
            return current;
        }

        public T GetItem(int index)
        {
            if (head == null || index < 0 || index >= _size)
                throw new IndexOutOfRangeException("Index was outside the bounds of the linked list.");

            Node<T> node = GetNode(index);
            return node.value;
        }

        public bool UpdateItem(int index, T newValue)
        {
            Node<T> node = GetNode(index);
            if (node != null)
            {
                node.value = newValue;
                return true;
            }

            return false;
        }

        public bool InsertAfter(int previousNodeIndex, T newNodeValue)
        {
            Node<T> node = GetNode(previousNodeIndex);
            if (node != null)
            {
                InsertAfter(node, newNodeValue);
                return true;
            }

            return false;
        }

    }
}
