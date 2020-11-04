using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace test
{
    class Tester_UI
    {
        static void Main(string[] args)
        {
            List<int> mylist = test(new List<int>(new int[] { 10, 22, 35, 47, 53, 67 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static List<int> test(List<int> nums)
        {
            return nums.Where(n => n % 10 < 7).ToList();
        }
    }
}
