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
            while((command = Console.ReadLine()) != "end")
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
                        default:
                            throw new Exception("Error: invalid command");
                    }
                }
                catch(Exception ex)
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
    }
}
