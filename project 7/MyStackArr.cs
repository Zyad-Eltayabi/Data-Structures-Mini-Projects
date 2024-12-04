using Data_Structures_Mini_Projects.project_4;
using Data_Structures_Mini_Projects.project_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Mini_Projects.project_7
{
    public class MyStackArr<T> : MyQueueArr<T>

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
