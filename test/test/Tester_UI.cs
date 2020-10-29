using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.IO;

namespace test
{
    class Tester_UI
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("Hello", "Hi"));
            Console.WriteLine(test("Python", "PHP"));
            Console.WriteLine(test("JS", "JS"));
            Console.WriteLine(test("Csharp", ""));
            Console.ReadLine();
        }

        public static string test(string str1, string str2)
        {
            string chars = "";
            if (str1.Length > 0)
                chars += str1.Substring(0, 1);
            else
            chars += "#";

            if (str2.Length > 0)
                chars += str2.Substring(str2.Length - 1);
            else
                chars += "#";

            return chars;
        }
    }
}
