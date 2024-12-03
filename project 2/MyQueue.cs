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

        public virtual void Push(T value)
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

        public T GetItem(int index)
        {
            return _myDoublyLinkedList.GetItem(index);
        }

        public void Reverse()
        {
            _myDoublyLinkedList.Reverse();
        }

        public void UpdateItem(int index, T value)
        {
            _myDoublyLinkedList.UpdateItem(index, value);
        }

        public void InsertAfter(int previousItemIndex, T value)
        {
            _myDoublyLinkedList.InsertAfter(previousItemIndex, value);
        }

        public void InsertAtFront(T value)
        {
            _myDoublyLinkedList.InsertAtFront(value);
        }

        public void InsertAtEnd(T value)
        {
            _myDoublyLinkedList.InsertAtEnd(value);
        }

        public void Clear()
        {
            _myDoublyLinkedList.Clear();
        }
    }
}
