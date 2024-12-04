using Data_Structures_Mini_Projects.project_4;


namespace Data_Structures_Mini_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyDynamicArray<int> myDynamicArray = new MyDynamicArray<int>(5);
            myDynamicArray.SetItem(0, 10);
            myDynamicArray.SetItem(1, 20);
            myDynamicArray.SetItem(2, 30);
            myDynamicArray.SetItem(3, 40);
            myDynamicArray.SetItem(4, 50);
            myDynamicArray.Print();


            Console.WriteLine("\nArray items after insert 400 at front");
            myDynamicArray.InsertAtFront(400);
            Console.WriteLine("Array Size = " + myDynamicArray.Size());
            myDynamicArray.Print();

            Console.WriteLine("\nArray items after insert 500 before index 2 ");
            myDynamicArray.InsertBefore(500, 2);
            Console.WriteLine("Array Size = " + myDynamicArray.Size());
            myDynamicArray.Print();

            Console.WriteLine("\nArray items after insert 600 after index 2 ");
            myDynamicArray.InsertAfter(600, 2);
            Console.WriteLine("Array Size = " + myDynamicArray.Size());
            myDynamicArray.Print();

            Console.WriteLine("\nArray items after insert 800 at the end ");
            myDynamicArray.InsertAtEnd(800);
            Console.WriteLine("Array Size = " + myDynamicArray.Size());
            myDynamicArray.Print();

        }
    }
}
