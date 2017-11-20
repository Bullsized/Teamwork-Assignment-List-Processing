using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing.Commands
{
    public class DeleteCommand<T> : Command<T>
    {
        public DeleteCommand(CustomList<T> target, int index, T value) : base(target, index, value)
        {
        }

        public override string Execute()
        {
            return target.Delete(this.index);
        }
    }
}
