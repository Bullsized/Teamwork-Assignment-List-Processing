using ListProcessing.Commands;
using ListProcessing.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ListProcessing.Factories
{
    public class CommandFactory
    {
        public static Command<T> Create<T>(string command, CustomList<T> list, IList<string> tokens)
        {
            string commandName = command.ToTitleCase() + "Command`1";
            string fullName = "ListProcessing.Commands." + commandName;
            Type type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == commandName);
            Type[] typeArgs = new Type[] { typeof(T) };
            Type constructedType = type.MakeGenericType(typeArgs);
            Command<T> instance = null;
            if (type != null)
            {
                instance = Activator.CreateInstance(constructedType, new object[] { list, tokens }) as Command<T>;
            }
            return instance;
        }
    }
}
