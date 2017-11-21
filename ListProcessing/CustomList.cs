using System;
using System.Collections.Generic;
using System.Linq;

namespace ListProcessing
{
    public class CustomList<T> : List<T>
    {
        public CustomList(IEnumerable<T> collection)
            : base(collection) { }

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

        public string RollRight()
        {
            if (this.Count <= 1)
            {
                return this.ToString();
            }
            var firstElement = this[Count - 1];
            this.RemoveAt(Count - 1);
            this.Insert(0, firstElement);
            return this.ToString();
        }
        public string CustomReverse()
        {
            this.Reverse();
            return this.ToString();
        }
        public int CountWord(string word)
        {
            return this.ToArray().Count(e => e.Equals(word));
        }
        public string InsertElement(int index, T element)
        {
            this.Insert(index, element);
            return this.ToString();
        }
        public string SortAlphabetically()
        {
            this.Sort();
            return this.ToString();
        }
        public override string ToString()
        {
            return String.Join(" ", this);
        }

    }
}