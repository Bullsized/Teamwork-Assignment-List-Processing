using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing.Commands
{
    public class PrependCommand<T> : Command<T>
    {
        public PrependCommand(CustomList<T> target, int index, T value) : base(target, index, value)
        {
        }

        public override string Execute()
        {
            return target.Prepend(value);
        }
    }
}
