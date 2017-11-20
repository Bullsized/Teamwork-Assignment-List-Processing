using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing.Commands
{
    public class RollRightCommand<T> : Command<T>
    {
        public RollRightCommand(CustomList<T> target, int index, T value) : base(target, index, value)
        {
        }

        public override string Execute()
        {
            return target.RollRight();
        }
    }
}
