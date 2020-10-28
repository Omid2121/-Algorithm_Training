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
            Console.WriteLine(test(4, 5, 7));
            Console.WriteLine(test(7, 4, 12));
            Console.WriteLine(test(10, 10, 12));
            Console.WriteLine(test(12, 12, 18));
            Console.WriteLine(test(12, 12, 12));
            Console.ReadLine();
        }

        public static int test(int x, int y,int z)
        {
            if (x == y)
                return z;
            
            if (x == z)
                return y;
            
            if (y == z)
                return x;
            
            else
                return x + y + z;
        }
    }
}
