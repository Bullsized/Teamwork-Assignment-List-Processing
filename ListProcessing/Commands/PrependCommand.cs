using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing.Commands
{
    public class PrependCommand<T> : Command<T>
    {
        public PrependCommand(CustomList<T> target, IList<T> tokens) : base(target, tokens)
        {
        }

        public override string Execute()
        {
            if(this.tokens.Count != 1)
            {
                throw new Exception("Error: invalid command parameters");
            }

            return target.Prepend(tokens[0]);
        }
    }
}
