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

            int index = myDynamicArray.Find(40);
            if(index != -1)
            {
                Console.WriteLine($"item 40 was found at index = {index}");
            }
            else
            {
                Console.WriteLine("the item is not found.");
            }

            myDynamicArray.DeleteItemByValue(40);
            Console.WriteLine("Array items after delete item (40)");
            myDynamicArray.Print();



        }
    }
}
