using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing
{
    class CustomList<T> : List<T>
    {
        public CustomList(IEnumerable<T> collection)
            :base(collection) { }

        public override string ToString()
        {
            return String.Join(" ", this);
        }
    }
}
