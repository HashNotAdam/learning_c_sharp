using System;
using System.Collections.Generic;

namespace list_quickstart
{
    class Program
    {
        private static string asterisk = "******************************";

        static void Main()
        {
            WriteClassName("ListOfStrings");
            new ListOfStrings().Call();
            WriteSpaceAndClassName("ListOfIntegers");
            new ListOfIntegers().Call();
        }

        private static void WriteClassName(string ClassName)
        {
            Console.WriteLine(asterisk);
            Console.WriteLine(ClassName);
            Console.WriteLine($"{asterisk}\n");
        }

        private static void WriteSpaceAndClassName(string ClassName)
        {
            WriteSpace();
            WriteClassName(ClassName);
        }

        private static void WriteSpace()
        {
            Console.WriteLine("\n\n");
        }
    }
}
