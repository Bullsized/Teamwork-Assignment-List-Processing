using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing.Commands
{
    public abstract class Command<T>
    {
        protected CustomList<T> target;
        protected T value;
        protected int index;
        public Command(CustomList<T> target, int index, T value)
        {
            this.target = target;
            this.value = value;
            this.index = index;
        }

        public abstract string Execute();
    }
}
