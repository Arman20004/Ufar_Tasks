using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ListWithArrays<T>
    {
            private T[] _elements;
            private int _size;
            private const int DefaultCapacity = 4;

            public ListWithArrays()
            {
                _elements = new T[DefaultCapacity];
            }

            public void Add(T item)
            {
                if (_size == _elements.Length)
                {
                    Resize(_elements.Length * 2);
                }
                _elements[_size++] = item;
            }

            public T RemoveLast()
            {
            if (_size == 0) { Console.WriteLine("No item to remove"); }

                T item = _elements[--_size];
                _elements[_size] = default(T); 

                if (_size > 0 && _size == _elements.Length / 4)
                {
                    Resize(_elements.Length / 2);
                }

                return item;
            }

            public int Count => _size;

            public bool IsEmpty => _size == 0;

            private void Resize(int newCapacity)
            {
                T[] newArray = new T[newCapacity];
                Array.Copy(_elements, newArray, _size);
                _elements = newArray;
            }
    }
}
