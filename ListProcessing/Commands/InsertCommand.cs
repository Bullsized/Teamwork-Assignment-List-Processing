using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing.Commands
{
    public class InsertCommand<T> : Command<T>
    {
        public InsertCommand(CustomList<T> target, int index, T value) : base(target, index, value)
        {
        }

        public override string Execute()
        {
            return target.InsertElement(this.index, this.value);
        }
    }
}
