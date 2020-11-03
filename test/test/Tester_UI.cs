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
            int[] item = test(new[] { 1, 2, 0, 3, 5, 7, 0, 9, 11 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] nums)
        {
            int pos = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    nums[i] = nums[pos];
                    nums[pos++] = 0;
                }
            }return nums;
        }
    }
}
