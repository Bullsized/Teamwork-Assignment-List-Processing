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

        public string Delete(int index)
        {
            this.RemoveAt(index);
            return this.ToString();
        }

        public string RollLeft()
        {
            if (this.Count <= 1)
            {
                return this.ToString();
            }
            var firstElement = this[0];
            this.RemoveAt(0);
            this.Add(firstElement);
            return this.ToString();
        }

        public override string ToString()
        {
            return String.Join(" ", this);
        }
       
    }
}
