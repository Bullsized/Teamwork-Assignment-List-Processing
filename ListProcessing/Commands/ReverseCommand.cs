using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing.Commands
{
    public class ReverseCommand<T> : Command<T>
    {
        public ReverseCommand(CustomList<T> target, IList<T> tokens) : base(target, tokens)
        {
        }

        public override string Execute()
        {
            if (tokens.Count != 0)
            {
                throw new Exception("Error: invalid command parameters");
            }

            return target.CustomReverse();
        }
    }
}
