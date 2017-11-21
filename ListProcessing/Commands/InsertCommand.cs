using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing.Commands
{
    public class InsertCommand<T> : Command<T>
    {
        public InsertCommand(CustomList<T> target, IList<T> tokens) : base(target, tokens)
        { 
        }

        public override string Execute()
        {
            if (tokens.Count != 2 || !int.TryParse(this.tokens[0].ToString(), out int index))
            {
                throw new Exception("Error: invalid command parameters");
            }


            if (index < 0 || index > target.Count - 1)
            {
                throw new Exception($"Error: invalid index {index}");
            }

            return target.InsertElement(index, this.tokens[1]);
        }
    }
}
