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
    }
}