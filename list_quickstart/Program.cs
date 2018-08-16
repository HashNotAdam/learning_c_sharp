using System;
using System.Collections.Generic;

namespace list_quickstart
{
    class Program
    {
        static void Main()
        {
            var names = SimpleList();
            AddAndRemoveFromList(names);
        }

        static List<string> SimpleList()
        {
            var names = new List<string> { "Adam", "Ana", "Felipe" };

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            return names;
        }

        static List<string> AddAndRemoveFromList(List<string> names)
        {
            Console.WriteLine();

            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            return names;
        }
    }
}
