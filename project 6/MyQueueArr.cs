using Data_Structures_Mini_Projects.project_4;
using DoublyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Mini_Projects.project_6
{
    public class MyQueueArr<T>
    {
        private MyDynamicArray<T> _myDynamicArray;
        public MyQueueArr()
        {
            _myDynamicArray = new MyDynamicArray<T>(0);
        }

        public virtual void Push(T value)
        {
            _myDynamicArray.InsertAtEnd(value);
        }

        public void Print()
        {
            _myDynamicArray.Print();
        }

        public void Pop()
        {
            _myDynamicArray.DeleteFirstItem();
        }

        public int Size()
        {
            return _myDynamicArray.Size();
        }

        public T Front()
        {
            return _myDynamicArray.GetItem(0);
        }

        public T Back()
        {
            return _myDynamicArray.GetItem(Size() - 1);
        }

        public bool IsEmpty()
        {
            return _myDynamicArray.IsEmpty();
        }
        public T GetItem(int index)
        {
            return _myDynamicArray.GetItem(index);
        }
        public void Reverse()
        {
            _myDynamicArray.Reverse();
        }
        public void UpdateItem(int index, T value)
        {
            _myDynamicArray.SetItem(index, value);
        }
        public void InsertAfter(int previousItemIndex, T value)
        {
            _myDynamicArray.InsertAfter(value, previousItemIndex);
        }
        public void InsertAtFront(T value)
        {
            _myDynamicArray.InsertAtFront(value);
        }
        public void InsertAtEnd(T value)
        {
            _myDynamicArray.InsertAtEnd(value);
        }
        public void Clear()
        {
            _myDynamicArray.Clear();
        }
    }
}
