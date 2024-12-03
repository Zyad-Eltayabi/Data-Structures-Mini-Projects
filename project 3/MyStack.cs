using Data_Structures_Mini_Projects.project_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Mini_Projects.project_3
{
    public class MyStack<T> : MyQueue<T>
    {

        public override void Push(T value)
        {
            InsertAtFront(value);
        }

        public T Top()
        {
            return Front();
        }

        public T Bottom()
        {
            return Back();
        }

    }
}
