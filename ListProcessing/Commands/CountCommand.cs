using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing.Commands
{
    public class CountCommand<T> : Command<T>
    {
        public CountCommand(CustomList<T> target, int index, T value) : base(target, index, value)
        {
        }

        public override string Execute()
        {
           return target.CountWord(value.ToString()).ToString();
        }
    }
}
