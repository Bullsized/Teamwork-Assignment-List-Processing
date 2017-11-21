using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing.Commands
{
    public abstract class Command<T>
    {
        protected CustomList<T> target;
        protected IList<T> tokens;
        public Command(CustomList<T> target, IList<T> tokens)
        {
            this.target = target;
            this.tokens = tokens;
        }

        public abstract string Execute();
    }
}
