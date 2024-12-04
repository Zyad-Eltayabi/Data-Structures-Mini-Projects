namespace Data_Structures_Mini_Projects
{
    internal partial class Program
    {
        public class UndoRedoStack<T>
        {
            private Stack<T> _undo;
            private Stack<T> _redo;
            private T _value;

            public UndoRedoStack()
            {
                _undo = new Stack<T>();
                _redo = new Stack<T>();
                _undo.Push(_value);
            }

            public T Value
            {
                get { return _value; }
                set
                {

                    if (_value == null || (!_value.Equals(value.ToString())))
                    {
                        _value = value;
                        _undo.Push(_value);
                    }
                }
            }

            public void Undo()
            {

                if (_undo.Count > 0)
                {
                    _redo.Push(_value);
                    _undo.Pop();
                    _value = _undo.Peek();
                }
            }

            public void Redo()
            {
                if (_redo.Count > 0)
                {
                    _value = _redo.Peek();
                    _undo.Push(_value);
                    _redo.Pop();
                }

            }

            public void Print() => Console.WriteLine($" value = {Value}");
        }
    }
}
