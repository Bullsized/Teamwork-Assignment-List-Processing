using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing.Commands
{
    public class SortCommand<T> : Command<T>
    {
        public SortCommand(CustomList<T> target, int index, T value) : base(target, index, value)
        {
        }

        public override string Execute()
        {
            return target.SortAlphabetically();
        }
    }
}
