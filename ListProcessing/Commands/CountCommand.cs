using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing.Commands
{
    public class CountCommand<T> : Command<T>
    {
        public CountCommand(CustomList<T> target, IList<T> tokens) : base(target, tokens)
        {
        }

        public override string Execute()
        {
            if (tokens.Count != 1)
            {
                throw new Exception("Error: invalid command parameters");
            }

            return target.CountWord(this.tokens[0].ToString()).ToString();
        }
    }
}
