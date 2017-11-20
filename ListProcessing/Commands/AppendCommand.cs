using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing.Commands
{
    public class AppendCommand<T> : Command<T>
    {
        public AppendCommand(CustomList<T> target, int index, T value) : base(target, index, value)
        {
        }

        public override string Execute()
        {
            return target.Append(this.value);
        }
    }
}
