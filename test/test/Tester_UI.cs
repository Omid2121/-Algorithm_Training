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
            Console.WriteLine(test(new[] { 1, 5, 6, 9, 10, 17 }));
            Console.WriteLine(test(new[] { 1, 5, 5, 5, 10, 17 }));
            Console.WriteLine(test(new[] { 1, 1, 5, 5, 5, 5 }));
        }

        public static bool test(int[] nums)
        {
                int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 5)
                {
                    sum += 5;
                }
            }
            return sum == 15;
        }
    }
}
