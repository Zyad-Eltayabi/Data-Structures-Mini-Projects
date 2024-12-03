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

            myDynamicArray.DeleteFirstItem();
            Console.WriteLine("Array after delete first item ");
            myDynamicArray.Print();

            myDynamicArray.DeleteLastItem();
            Console.WriteLine("Array after delete last item ");
            myDynamicArray.Print();


        }
    }
}
