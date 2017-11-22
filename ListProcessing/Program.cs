using ListProcessing.Commands;
using ListProcessing.Extensions;
using ListProcessing.Factories;
using System;
using System.Linq;

namespace ListProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new CustomList<string>(Console.ReadLine().Split());
            Console.WriteLine(list);

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                var tokens = command.Split();

                try
                {
                    string commandName = string.Empty;
                    string[] resultTokens = null;
                    if (tokens.Length > 1)
                    {
                        if (tokens[1].ToLower() == "left" || tokens[1].ToLower() == "right")
                        {
                            commandName = tokens[0].ToTitleCase() + tokens[1].ToTitleCase();
                            resultTokens = tokens.Skip(2).ToArray();
                        }
                        else
                        {
                            commandName = tokens[0];
                            resultTokens = tokens.Skip(1).ToArray();
                        }
                    }
                    else
                    {
                        commandName = tokens[0];
                        resultTokens = tokens.Skip(1).ToArray();
                    }
                    Command<string> commandInstance = CommandFactory.Create(commandName, list, resultTokens);
                    Console.WriteLine(commandInstance.Execute());

                }
                catch (NullReferenceException nrex)
                {
                    Console.WriteLine("Error: invalid command");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Finished");
        }
    }
}