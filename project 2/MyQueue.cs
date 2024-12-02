using DoublyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Mini_Projects.project_2
{
    public class MyQueue<T>
    {
        private MyDoublyLinkedList<T> _myDoublyLinkedList;
        public MyQueue()
        {
            _myDoublyLinkedList = new MyDoublyLinkedList<T>();
        }

        public void Push(T value)
        {
            _myDoublyLinkedList.InsertAtEnd(value);
        }

        public void Print()
        {
            _myDoublyLinkedList.Print();
        }

        public void Pop()
        {
            _myDoublyLinkedList.DeleteFirstNode();
        }

        public int Size()
        {
            return _myDoublyLinkedList.Size();
        }

        public T Front()
        {
            return _myDoublyLinkedList.GetItem(0);
        }

        public T Back()
        {
            return _myDoublyLinkedList.GetItem(Size() - 1);
        }

        public bool IsEmpty()
        {
            return _myDoublyLinkedList.IsEmpty();
        }
    }
}
