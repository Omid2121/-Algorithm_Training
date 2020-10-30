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
            int[] item = test(new[] { 10, 20, -30, -40 });

            Console.Write("Rotated array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] nums)
        {
            return new int[] { nums[1], nums[2], nums[3], nums[0] };
        }
    }
}
