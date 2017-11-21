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

        private static void SortingCheckAndPrint(CustomList<string> list, string[] tokens)
        {
            if (tokens.Length > 0)
            {
                Console.WriteLine("Error: invalid command parameters");
            }
            list.Sort();
            Console.WriteLine(list);
        }

        private static int CountTheWord(CustomList<string> list, string wordNeeded)
        {
            int returnCounter = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == wordNeeded)
                {
                    returnCounter++;
                }
            }
            return returnCounter;
        }

        static string ExexuteAppend(CustomList<string> list, string[] tokens)
        {
            if (tokens.Length != 2)
            {
                throw new Exception("Error: invalid command parameters");
            }

            return list.Append(tokens[1]);
        }

        static string ExecutePrepend(CustomList<string> list, string[] tokens)
        {
            if (tokens.Length != 2)
            {
                throw new Exception("Error: invalid command parameters");
            }

            return list.Prepend(tokens[1]);
        }

        static string ExacuteInsert(CustomList<string> list, string[] tokens)
        {
            if (tokens.Length != 3)
            {
                throw new ArgumentException("Error: invalid command parameters");
            }

            string receivedIndex = tokens[1];
            int index;
            if (!int.TryParse(receivedIndex, out index) || (index < 0 || index > list.Count - 1))
            {
                throw new ArgumentException($"Error: invalid index {receivedIndex}");
            }

            list.Insert(index, tokens[2]);
            return list.ToString();
        }

        static string ExecuteDelete(CustomList<string> list, string[] tokens)
        {
            if (tokens.Length != 2)
            {
                throw new ArgumentException("Error: invalid command parameters");
            }

            string receivedIndex = tokens[1];
            int index;
            if (!int.TryParse(receivedIndex, out index) || (index < 0 || index > list.Count - 1))
            {
                throw new ArgumentException($"Error: invalid index {receivedIndex}");
            }

            list.Delete(index);
            return list.ToString();

        }

    }
}