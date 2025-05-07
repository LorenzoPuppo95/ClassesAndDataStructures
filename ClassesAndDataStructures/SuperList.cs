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

        public void Add(T item)
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
    }
}
