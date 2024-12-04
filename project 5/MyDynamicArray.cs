using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Mini_Projects.project_4
{
    public class MyDynamicArray<T>
    {
        private T[] _array;
        private T[] _tempArray;
        private int _size;
        public MyDynamicArray(int size)
        {
            if (size < 0)
            {
                size = 0;
            }
            _size = size;
            _array = new T[size];
            _tempArray = new T[0];
        }
        public void SetItem(int index, T item)
        {
            if (index >= _size)
                throw new ArgumentOutOfRangeException(nameof(index), "The index must be less than the size of array");
            _array[index] = item;
        }
        public void Print()
        {
            Console.WriteLine("Array Items :");
            foreach (T item in _array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public int Size()
        {
            return _size;
        }

        public void Resize(int newSize)
        {
            if (_size < 0 || _size == newSize)
                return;

            _tempArray = new T[newSize];


            if (newSize < _size)
                _size = newSize;

            for (int i = 0; i < _size; i++)
            {
                _tempArray[i] = _array[i];
            }

            _size = newSize;
            this._array = _tempArray;
        }

        public T GetItem(int index)
        {
            if (index < 0 || index >= _size)
                throw new ArgumentOutOfRangeException(nameof(index));

            return _array[index];
        }

        private void Swap(ref T num1, ref T num2)
        {
            T temp = num1;
            num1 = num2;
            num2 = temp;
        }

        public void Reverse()
        {
            // old solution
            /*_tempArray = new T[_size];
            int counter = 0;
            for (int i = _size - 1; i >= 0; i--)
            {
                _tempArray[counter++] = _array[i];
            }
            _array = _tempArray;*/

            int length = _size / 2;
            for (int i = 0; i < length; i++)
            {
                Swap(ref _array[i], ref _array[_size - i - 1]);
            }
        }

        public void Clear()
        {
            _array = _tempArray = new T[0];
            _size = 0;
        }

        private bool IsIndexValid(int index)
        {
            if (index < 0 || index >= _size)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "The index is not valid");
            }
            return true;
        }

        public void DeleteItemAt(int index)
        {
            IsIndexValid(index);

            _tempArray = new T[_size - 1];

            int counter = 0;

            for (int i = 0; i < _size; i++)
            {
                if (i != index)
                    _tempArray[counter++] = _array[i];
            }

            _size -= 1;
            _array = _tempArray;
        }

        public void DeleteLastItem()
        {
            //Resize(_size - 1);
            DeleteItemAt(_size - 1);
        }

        public void DeleteFirstItem()
        {
            // old solution
            /*if(_size == 0)
                return;

            _tempArray = new T[_size - 1];

            for (int i = 1; i < _size; i++)
            {
                _tempArray[i - 1] = _array[i];
            }

            _size -= 1;
            _array = _tempArray*/
            ;

            DeleteItemAt(0);

        }

        public int Find(T item)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_array[i].Equals(item))
                    return i;
            }
            return -1;
        }

        public void DeleteItemByValue(T item)
        {
            // first find the item's index
            int indexItem = Find(item);
            if (indexItem != -1)
                DeleteItemAt(indexItem);
        }

        public void InsertAt(T item, int index)
        {
            if (index < 0 || index > _size)
                index = 0;

            _tempArray = new T[_size + 1];

            // copy all the values that before the given index 
            for (int i = 0; i < index; i++)
                _tempArray[i] = _array[i];

            // set new item value in _tempArray
            _tempArray[index] = item;

            // copy all the items in _array from the given index until the end
            for (int i = index; i < _size; i++)
                _tempArray[i + 1] = _array[i];

            _size++;
            _array = _tempArray;
        }

        public void InsertAtFront(T item)
        {
            InsertAt(item, 0);
        }

        public void InsertBefore(T item, int index)
        {
            if (index < 1)
            {
                InsertAt(item, 0);
                return;
            }

            InsertAt(item, index - 1);
        }

        public void InsertAfter(T item, int index)
        {
            if (index >= _size)
            {
                InsertAt(item, _size - 1);
                return;
            }
            InsertAt(item, index + 1);
        }

        public void InsertAtEnd(T item)
        {
            Resize(_size + 1);
            _array[_size - 1] = item;
        }
    }
}