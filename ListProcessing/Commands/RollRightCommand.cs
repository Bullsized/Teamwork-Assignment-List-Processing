using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing.Commands
{
    public class RollRightCommand<T> : Command<T>
    {
        public RollRightCommand(CustomList<T> target, IList<T> tokens) : base(target, tokens)
        {
        }

        public override string Execute()
        {
            if (tokens.Count != 0)
            {
                throw new Exception("Error: invalid command parameters");
            }

            return target.RollRight();
        }
    }
}
