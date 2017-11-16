using System;

namespace ListProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new CustomList<string>(Console.ReadLine().Split());
            Console.WriteLine(list);
        }
    }
}
