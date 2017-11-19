using System;
using System.Collections.Generic;

namespace ListProcessing
{
    class CustomList<T> : List<T>
    {
        public CustomList(IEnumerable<T> collection)
            :base(collection) { }

        public string Append(T element)
        {
            this.Add(element);
            return this.ToString();
        }

        public string Prepend(T element)
        {
            this.Insert(0, element);
            return this.ToString();
        }

    

        public override string ToString()
        {
            return String.Join(" ", this);
        }
       
    }
}
