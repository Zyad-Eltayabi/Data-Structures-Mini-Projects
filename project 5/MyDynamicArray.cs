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
        private int _size;
        public MyDynamicArray(int size)
        {
            if (size < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size), "The size must be a non-negative number.");
            }
            _array = new T[size];
            _size = size;
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
    }
}