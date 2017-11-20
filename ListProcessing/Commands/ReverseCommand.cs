using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing.Commands
{
    public class ReverseCommand<T> : Command<T>
    {
        public ReverseCommand(CustomList<T> target, int index, T value) : base(target, index, value)
        {
        }

        public override string Execute()
        {
            return target.Reverse();
        }
    }
}
