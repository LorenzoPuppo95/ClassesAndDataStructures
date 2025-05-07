using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndDataStructures
{
    internal class SuperList<T>
    {
        private T[] _realArray;

        public SuperList()
        {
            _realArray = new T[0];
        }

        public void Push(T item)
        {
            var originalLength = _realArray.Length;
            var newArray = new T[originalLength + 1];
            for (int i = 0; i < originalLength; i++)
            {
                newArray[i] = _realArray[i];
            }
            newArray[originalLength] = item;
            _realArray = newArray;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _realArray.Length)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            return _realArray[index];
        }

        public T Pop()
        {
            if (_realArray.Length == 0)
            {
                throw new InvalidOperationException("List is empty");
            }
            int originalLength = _realArray.Length;
            int newLength = originalLength - 1;
            var newArray = new T[newLength];
            T element = _realArray[originalLength - 1];
            for (int i = 0; i < newLength; i++)
            {
                newArray[i] = _realArray[i];
            }
            _realArray = newArray;
            return element;
        }
    }
}
