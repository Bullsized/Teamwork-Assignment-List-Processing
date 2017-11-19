using System;

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
                    switch (tokens[0])
                    {
                        case "append":
                            Console.WriteLine(ExexuteAppend(list, tokens));
                            break;
                        case "prepend":
                            Console.WriteLine(ExecutePrepend(list, tokens));
                            break;
                        case "reverse":
                            list.Reverse();
                            Console.WriteLine(list);
                            break;
                        case "insert":
                            Console.WriteLine(ExacuteInsert(list, tokens));
                            break;
                        case "delete":
                            Console.WriteLine(ExecuteDelete(list, tokens));
                            break;
                        default:
                            throw new Exception("Error: invalid command");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Finished");
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
            if (!int.TryParse(receivedIndex, out index) || (index < 0 || index > list.Count -1))
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
