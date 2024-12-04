using Data_Structures_Mini_Projects.project_2;
using Data_Structures_Mini_Projects.project_3;
using Data_Structures_Mini_Projects.project_4;
using Data_Structures_Mini_Projects.project_6;
using Data_Structures_Mini_Projects.project_7;
using System.Collections;


namespace Data_Structures_Mini_Projects
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //  Test The methods

            UndoRedoStack<string> undoRedo = new UndoRedoStack<string>();
            undoRedo.Print();
            undoRedo.Value = "1";
            undoRedo.Print();

            undoRedo.Value = "2";
            undoRedo.Print();

            undoRedo.Value = "3";
            undoRedo.Print();

            Console.WriteLine("\n\nApply undo");
            undoRedo.Undo();
            undoRedo.Print();
            undoRedo.Undo();
            undoRedo.Print();
            undoRedo.Undo();
            undoRedo.Print();

            Console.WriteLine("\n\nApply redo");
            undoRedo.Redo();
            undoRedo.Print();
            undoRedo.Redo();
            undoRedo.Print();
            undoRedo.Redo();
            undoRedo.Print();


        }
    }
}
