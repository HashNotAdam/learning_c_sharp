using System;
using System.Collections.Generic;

namespace list_quickstart
{
    class Program
    {
        static void Main()
        {
            ListOfStrings.Call();
        }
    }

    class ListOfStrings
    {
        public static void Call()
        {
            var names = SimpleList();
            AddAndRemoveFromList(names);
            PrintItemsByReference(names);
            CountItemsInList(names);
            SearchList(names);
            SortList(names);
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

        static void PrintItemsByReference(List<string> names)
        {
            Console.WriteLine(
                $"\nMy name is {names[0]}" +
                $"\nI've added {names[2]} and {names[3]} to the list"
            );
        }

        static void CountItemsInList(List<string> names)
        {
            Console.WriteLine($"\nThe list has {names.Count} people in it");
        }

        static void SearchList(List<string> names)
        {
            Console.WriteLine();

            var searches = new List<string> { "Felipe", "Not Found" };
            foreach (var search in searches)
            {
                var index = names.IndexOf(search);
                var message = SearchMessage(names, index);
                Console.WriteLine(message);
            }
        }

        static string SearchMessage(List<string> names, int index)
        {
            return index == -1 ?
                $"When an item is not found, IndexOf returns {index}" :
                $"The name {names[index]} is at index {index}";
        }

        static void SortList(List<string> names)
        {
            Console.WriteLine();

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
