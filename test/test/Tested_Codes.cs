using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    /*
     * 
     * 
     * 
    static void Main(string[] args)
    {

        Console.WriteLine(test("abcd"));
        Console.WriteLine(test("a"));
        Console.WriteLine(test("xy"));
        Console.ReadLine();
    }

    public static string test(string str)
    {
        if (str.Length > 1)

            return str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1);

        return str;

    }



    static void Main(string[] args)
    {

        Console.WriteLine(test("C Sharp"));
        Console.WriteLine(test("JS"));
        Console.WriteLine(test("a"));
        Console.ReadLine();
    }

    public static string test(string str)
    {
        if (str.Length < 2)
            return str;

        return str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2);

    }




    static void Main(string[] args)
    {

        Console.WriteLine(test(3));
        Console.WriteLine(test(14));
        Console.WriteLine(test(12));
        Console.WriteLine(test(37));
        Console.ReadLine();
    }

    public static bool test(int x)
    {
        return x % 3 == 0 || x % 7 == 0;
    }'



    static void Main(string[] args)
    {

        Console.WriteLine(test("Python"));
        Console.WriteLine(test("JS"));
        Console.WriteLine(test("Code"));
        Console.ReadLine();
    }

    public static string test(string str)
    {
        if (str.Length < 3)
        {
            return str + str + str;

        }
        else
        {
            string front = str.Substring(0, 3);
            return front + str + front;
        }

    }





    static void Main(string[] args)
        {
          
            Console.WriteLine(test("C# Sharp"));
            Console.WriteLine(test("C#"));
            Console.WriteLine(test("C++"));
            Console.ReadLine();
        }

        public static bool test(string str)
        {
            if (str.Substring(0,2) =="C#")
            {
                return true;
            }
            else
            {
                return false;
            }
        }





    static void Main(string[] args)
        {
          
            Console.WriteLine(test(120,-1));
            Console.WriteLine(test(-1,120));
            Console.WriteLine(test(2,120));
            Console.ReadLine();
        }

        public static bool test(int temp1, int temp2)
        {
            if (temp1 < 0 && temp2 > 100 || temp2 < 0 && temp1 > 100)
                return true;
              return false;
        }






    static void Main(string[] args)
        {
          
            Console.WriteLine(test(100,199));
            Console.WriteLine(test(250,300));
            Console.WriteLine(test(105,190));
            Console.ReadLine();
        }

        public static bool test(int temp1, int temp2)
        {
            if (temp1 >= 100 && temp1 <= 200 || temp2 >= 100 && temp2 <= 200)
                return true;
                return false;

        }






     static void Main(string[] args)
        {
          
            Console.WriteLine(test(11, 20, 12));
            Console.WriteLine(test(30, 30, 17));
            Console.WriteLine(test(25, 35, 50));
            Console.WriteLine(test(15, 12, 8));

            Console.ReadLine();
        }


        public static bool test(int x, int y, int z)
        {
                return (x >= 20 && x <= 50) || (y >= 20 && y <= 50) || (z >= 20 && z <= 50);
        }




     static void Main(string[] args)
        {
          
            Console.WriteLine(test(20, 84));
            Console.WriteLine(test(14, 50));
            Console.WriteLine(test(11, 45));
            Console.WriteLine(test(25, 40));

            Console.ReadLine();
        }


        public static bool test(int x, int y)
        {
            if ((x <= 20 || y >= 50) || (x >= 50 && y <= 20))
            {
                return true;
            }
            return false;
        }






      static void Main(string[] args)
        {
          
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("ytade"));
            Console.WriteLine(test("jsues"));
            Console.WriteLine(test("syton"));

            Console.ReadLine();
        }

        public static string test(string str)
        {
            if (str.Substring(1,2) =="yt")
            {
                return str.Remove(1, 2);
            }
            return str;
        }





    static void Main(string[] args)
        {

            Console.WriteLine(test(1, 2, 3));
            Console.WriteLine(test(1, 3, 2));
            Console.WriteLine(test(1, 1, 1));
            Console.WriteLine(test(1, 2, 2));

            Console.ReadLine();
        }


        public static int test(int x, int y, int z)
        {
            var max = Math.Max(x, Math.Max(y, z));
            return max;
        }




    static void Main(string[] args)
        {

            Console.WriteLine(test(78, 95));
            Console.WriteLine(test(95, 95));
            Console.WriteLine(test(99, 70));
            Console.WriteLine(test(1, 2));

            Console.ReadLine();
        }


        public static int test(int x, int y)
        {
            var max = Math.Max(x, Math.Max(x, y));

            if (x == y)
            {
                return 0;
            }
            return max;
        }





    static void Main(string[] args)
        {

            Console.WriteLine(test(78, 95));
            Console.WriteLine(test(20, 30));
            Console.WriteLine(test(21, 25));
            Console.WriteLine(test(28, 28));

            Console.ReadLine();
        }

        public static int test(int x, int y)
        {
            if (x <= 30 && y >=20 || x >= 20 && y <= 30)
            {
                var max = Math.Max(x, Math.Max(x, y));
                return max;
            }
            return 0;
        }




     static void Main(string[] args)
        {

            Console.WriteLine(test("frizz"));
            Console.WriteLine(test("zane"));
            Console.WriteLine(test("Zazz"));
            Console.WriteLine(test("false"));

            Console.ReadLine();
        }

        public static bool test(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'z')
                {
                    count++;
                }
            }
            return count > 1 && count <= 4;
        }




    //if last digit are the same return true
    static void Main(string[] args)
        {

            Console.WriteLine(test(123, 456));
            Console.WriteLine(test(12, 512));
            Console.WriteLine(test(7, 87));
            Console.WriteLine(test(12, 45));

            Console.ReadLine();
        }


        public static bool test(int x, int y)
        {
            return Math.Abs(x % 100) == Math.Abs(y % 100);
        }





    //last 3 chars converts to upper case
    static void Main(string[] args)
        {

            Console.WriteLine(test("Python"));
            Console.WriteLine(test("Javascript"));
            Console.WriteLine(test("js"));
            Console.WriteLine(test("PHP"));

            Console.ReadLine();
        }

        public static string test(string str)
        {
            if (str.Length > 2)
            {
                return str.Remove(str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
            }
            return str.ToUpper();
        }




    // copies n time the string
    static void Main(string[] args)
        {

            Console.WriteLine(test("JS",2));
            Console.WriteLine(test("JS",3));
            Console.WriteLine(test("jS",1));
            Console.WriteLine(test("JS",4));

            Console.ReadLine();
        }

        public static string test(string str, int n)
        {
            string result = String.Empty;
            for (int i = 0; i < n; i++)
            {
                result += str;
            }
            return result;
        }






     static void Main(string[] args)
        {

            Console.WriteLine(Test("bbaaccaag"));
            Console.WriteLine(Test("jjkiaaasew"));
            Console.WriteLine(Test("JSaaakoiaa"));

            Console.ReadLine();
        }

        public static int Test(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str.Substring(i,2) == "aa")
                {
                    count++;
                }
            }
            return count;
            
        }







    //if a immediately came after a return true
    static void Main(string[] args)
        {

            Console.WriteLine(Test("caabb"));
            Console.WriteLine(Test("babaaba"));
            Console.WriteLine(Test("aaaaa"));

            Console.ReadLine();
        }

        public static bool Test(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length -1; i++)
            {
                if (str[i] == 'a')
                {
                    count++;
                }
                if (str.Substring(i,2) == "aa" && count <2)
                {
                    return true;
                }
            }
            return false;
        }






    //every other char is output.
    static void Main(string[] args)
        {
            Console.WriteLine(Test("Python"));
            Console.WriteLine(Test("PHP"));
            Console.WriteLine(Test("JS"));

            Console.ReadLine();
        }

        public static string Test(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += str[i];
                }
            }
            return result;
        }







    static void Main(string[] args)
        {
            Console.WriteLine(Test("abcd"));
            Console.WriteLine(Test("abc"));
            Console.WriteLine(Test("a"));

            Console.ReadLine();
        }

        public static string Test(string str)
        {
            var result = "";
            for (var i = 0; i < str.Length; i++)
            {
                result += str.Substring(0, i + 1);
            }
            return result;
        }







    static void Main(string[] args)
        {
            Console.WriteLine(Test("abcdsab"));
            Console.WriteLine(Test("abcdabab"));
            Console.WriteLine(Test("abcabdabab"));
            Console.WriteLine(Test("abcabd"));


            Console.ReadLine();
        }

        public static int Test(string str)
        {
            var lastChar = str.Substring(str.Length - 2);
            var counter = 0;

            for (int i = 0; i < str.Length -2 ; i++)
            {
                if (str.Substring(i,2) == lastChar)
                {
                    counter++;
                }
            }
            return counter;
        }



    

    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 2, 9, 3 }, 3));
            Console.WriteLine(test(new[] { 1, 2, 2, 3 }, 2));
            Console.WriteLine(test(new[] { 1, 2, 2, 3 }, 9));
            Console.ReadLine();
        }

        public static bool test(int[] numbers, int n)
        {
            if (numbers.Contains(n))
                return true;
            return false;
        }





     static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 2, 9, 3 }, 3));
            Console.WriteLine(test(new[] { 1, 2, 3, 4, 5, 6 }, 2));
            Console.WriteLine(test(new[] { 1, 2, 2, 3 }, 9));
            Console.WriteLine(test(new[] { 1, 2, 3, 4, 5, 6 }, 4));

            Console.ReadLine();
        }

        public static bool test(int[] numbers, int n)
        {
            if (numbers.Length < 4)
            {
                return numbers.Contains(n);
            }
            return numbers.Take(4).Contains(n);
        }






    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 1, 2, 3, 1 }));
            Console.WriteLine(test(new[] { 1, 1, 2, 4, 1 }));
            Console.WriteLine(test(new[] { 1, 1, 2, 1, 2, 3 }));
            Console.ReadLine();
        }

        public static bool test(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 2 && numbers[i + 2] == 3)
                {
                    return true;
                }
            }
                return false;
            
        }






    //* 
    // compares if 2 strings have same chars
    static void Main(string[] args)
        {
            Console.WriteLine(test("abcdefgh", "abijsklm"));
            Console.WriteLine(test("abcde", "osuefrcd"));
            Console.WriteLine(test("pqrstuvwx", "pqkdiewx"));
            Console.ReadLine();
        }

        public static int test(string str1, string str2)
        {
            var counter = 0;
            for (int i = 0; i < str1.Length -1 ; i++)
            {
                var firstString = str1.Substring(i, 2);
                for (int j = 0; j < str2.Length -1 ; j++)
                {
                    var secoundString = str2.Substring(j, 2);
                    if (firstString == secoundString)
                        counter++;
                }
            }
            return counter;
        }




    //* 
    //if str2 found in str1 delete the value in str1 unless at start and ending
     static void Main(string[] args)
        {
            Console.WriteLine(test("xxHxix", "x"));
            Console.WriteLine(test("abxdddca", "a"));
            Console.WriteLine(test("xabjbhtrb", "b"));
            Console.ReadLine();
        }

        public static string test(string str1, string str2)
        {
           
            for (int i = str1.Length -2; i > 0 ; i--)
            {
                if (str1[i] == str2[0])
                {
                    str1 = str1.Remove(i, 1);
                }
            }
            return str1;
        }






    //* 
    static void Main(string[] args)
        {
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("JavaScript"));
            Console.WriteLine(test("HTML"));
            Console.ReadLine();
        }

        public static string test(string str1)
        {
            var result = "";
            for (int i = 0; i < str1.Length; i+= 4)
            {
                var c = i + 2;
                var n = 0;
                n += c > str1.Length ? 1 : 2;
                
                    result += str1.Substring(i, n);
                
            }
            return result;
        }






    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 5, 5, 2 }));
            Console.WriteLine(test(new[] { 5, 5, 2, 5, 5 }));
            Console.WriteLine(test(new[] { 5, 6, 2, 9 }));
            Console.ReadLine();
        }

        public static int test(int[] num)
        {
            var counter = 0;
            for (int i = 0; i < num.Length - 1; i++)
            {
                if (num[i] == 5 && num[i + 1] == 5 || num[i + 1] == 6)
                {
                    counter++;
                }
            }return counter;
        }






    //*
    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 1, 2, 2, 1 }));
            Console.WriteLine(test(new[] { 1, 1, 2, 1, 2, 3 }));
            Console.WriteLine(test(new[] { 1, 1, 1, 2, 2, 2, 1 }));
            Console.ReadLine();
        }

        public static bool test(int[] num)
        {
            int arrayLength = num.Length - 1, n = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                n = num[i];
                if (n == num[i + 1] && n == num[i + 2])
                {
                    return true;
                }
               
            }return false;
        }






    static void Main(string[] args)
        {
            Console.WriteLine(test(12, 17));
            Console.WriteLine(test(2, 17));
            Console.WriteLine(test(22, 17));
            Console.WriteLine(test(20, 0));
            Console.ReadLine();
        }

        public static int test(int num1, int num2)
        {
            if (num1 + num2 >= 10 && num1 + num2 <= 20)
            {
                return 30;
            }
            return num1 + num2;
        }





    static void Main(string[] args)
        {
            Console.WriteLine(test(5, 4));
            Console.WriteLine(test(4, 3));
            Console.WriteLine(test(1, 4));
            Console.WriteLine(test(2, 5));
            Console.ReadLine();
        }

        public static bool test(int num1, int num2)
        {
            if (num1 == 5 || num2 == 5 || num1 + num2 == 5 || Math.Abs(num1 - num2) == 5)
            {
                return true;
            }
            return false;
        }






    static void Main(string[] args)
        {
            Console.WriteLine(test(13));
            Console.WriteLine(test(14));
            Console.WriteLine(test(27));
            Console.WriteLine(test(41));
            Console.ReadLine();
        }

        public static bool test(int num1)
        {
            return num1 % 13 == 0 || num1 % 13 == 1;
        }




    static void Main(string[] args)
        {
            Console.WriteLine(test(3));
            Console.WriteLine(test(7));
            Console.WriteLine(test(21));
            Console.WriteLine(test(41));
            Console.ReadLine();
        }

        public static bool test(int num1)
        {

            return num1 % 3 == 0 ^ num1 % 7 == 0;
            
        }





     static void Main(string[] args)
        {
            Console.WriteLine(test(3));
            Console.WriteLine(test(7));
            Console.WriteLine(test(21));
            Console.WriteLine(test(41));
            Console.ReadLine();
        }

        public static bool test(int num1)
        {

            return num1 % 10 <= 2 || num1 % 10 >= 8;
            
        }





    static void Main(string[] args)
        {
            Console.WriteLine(test(3,7));
            Console.WriteLine(test(10,11));
            Console.WriteLine(test(10,20));
            Console.WriteLine(test(21,220));
            Console.ReadLine();
        }

        public static int test(int num1,int num2)
        {
            if ((num1 >= 10 && num1 <= 20) || (num2 >= 10 && num2 <= 20))
            {
                return 18;
            }
            return num1 + num2;
        }





    static void Main(string[] args)
        {
            Console.WriteLine(test(1, 2, 3));
            Console.WriteLine(test(4, 5, 6));
            Console.WriteLine(test(-1, 1, 0));
            Console.WriteLine(test(3, 6, 3));

            Console.ReadLine();
        }

        public static bool test(int x, int y, int z)
        {
            return x == y + z || y == x + z || z == x + y;
        }





    static void Main(string[] args)
        {
            Console.WriteLine(test(1, 2, 3));
            Console.WriteLine(test(4, 5, 6));
            Console.WriteLine(test(-1, 1, 0));
            Console.WriteLine(test(3, 6, 3));

            Console.ReadLine();
        }

        public static bool test(int x, int y, int z)
        {
            if (x < y && y< z)
            {
                return true;
            }
            return false;     
        }





     static void Main(string[] args)
        {
            Console.WriteLine(test(1, 2, 3, false));
            Console.WriteLine(test(1, 2, 3, true));
            Console.WriteLine(test(10, 2, 30, false));
            Console.WriteLine(test(10, 10, 30, true));
            Console.ReadLine();
        }

        public static bool test(int x, int y, int z, bool flag)
        {
            if (flag)
            {
                return x <= y && y <= z;
            }
            else
            {
                return x < y && y < z;
            }
        }




     static void Main(string[] args)
        {
            Console.WriteLine(test(11, 21, 31));
            Console.WriteLine(test(11, 22, 31));
            Console.WriteLine(test(11, 22, 33));
            Console.ReadLine();
        }

        public static bool test(int x, int y, int z)
        {
            return x % 10 == y % 10 || x % 10 == z % 10 || z % 10 == y % 10;
        }



    static void Main(string[] args)
        {
            Console.WriteLine(test(11, 21, 31));
            Console.WriteLine(test(11, 22, 31));
            Console.WriteLine(test(10, 20, 15));
            Console.ReadLine();
        }

        public static bool test(int x, int y, int z)
        {
            if (Math.Abs(x - y) >= 20 || Math.Abs(x - z) >= 20 || Math.Abs(z - y) >= 20) 
            {
                return true;
            }
            return false;
        }




    static void Main(string[] args)
        {
            Console.WriteLine(test(30, 7));
            Console.WriteLine(test(11, 21));
            Console.WriteLine(test(11, 20));
            Console.WriteLine(test(10, 10));
            Console.ReadLine();
        }

        public static int test(int x, int y)
        {
            if (x == y)
            {
                return 0;
            }
            else if ((x % 7 == y % 7 && x < y) || x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }





    //*  53
     static void Main(string[] args)
        {
            Console.WriteLine(test(11, 21));
            Console.WriteLine(test(11, 20));
            Console.WriteLine(test(10, 10));
            Console.WriteLine(test(101, 10));

            Console.ReadLine();
        }

        public static bool test(int x, int y)
        {
            if ((x >= 10 && y <= 99 || x <= 99 && y >= 10) && x % 10 == y % 10)
            {
                return true;
            }
            return false;
        }





    static void Main(string[] args)
        {
            Console.WriteLine(test(4, 5));
            Console.WriteLine(test(7, 4));
            Console.WriteLine(test(10, 10));
            Console.WriteLine(test(1, 10));


            Console.ReadLine();
        }

        public static int test(int x, int y)
        {
            if ((x + y).ToString().Length <= x.ToString().Length)
            {
                return x + y;
            }
            return x;
        }





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





    static void Main(string[] args)
        {
            Console.WriteLine(test(4, 5, 7));
            Console.WriteLine(test(7, 4, 12));
            Console.WriteLine(test(10, 13, 12));
            Console.WriteLine(test(13, 12, 18));
            Console.ReadLine();
        }

        public static int test(int x, int y,int z)
        {
            if (x == 13)
                return 0;
            if (y == 13)
                return x;
            if (z == 13)
                return x + y;
            else
                return x + y + z;
        }



    //*
    static void Main(string[] args)
        {
            Console.WriteLine(test(4, 5, 7));
            Console.WriteLine(test(7, 4, 12));
            Console.WriteLine(test(10, 13, 12));
            Console.WriteLine(test(17, 12, 18));

            Console.ReadLine();
        }

        public static int test(int x, int y,int z)
        {
            return Nums(x) + Nums(y) + Nums(z);          
        }
        public static int Nums(int n)
        {
            if ((n > 9 && n < 13) || (n > 17 && n < 21))
            {
                return 0;
            }
            return n;
        }





      static void Main(string[] args)
        {
            Console.WriteLine(test(4, 5));
            Console.WriteLine(test(7, 12));
            Console.WriteLine(test(10, 13));
            Console.WriteLine(test(17, 33));
            Console.ReadLine();
        }

        public static int test(int x, int y)
        {
            if (x <= 13 || y <= 13)
            {
                if (x >= y)
                {
                    return x;
                }
                return y;
            }
            return 0;
        }





    static void Main(string[] args)
        {
            Console.WriteLine(test(4, 5, 6));
            Console.WriteLine(test(7, 12, 13));
            Console.WriteLine(test(-1, 0, 1));
            Console.ReadLine();
        }

        public static bool test(int x, int y, int z)
        {
            int val1 = y - x;
            int val2 = z - y;
            if (val1 == val2)
            {
                return true;
            }
            return false;
        }




    static void Main(string[] args)
        {
            Console.WriteLine(test("Hi", "Hello"));
            Console.WriteLine(test("whats", "app"));
            Console.ReadLine();
        }

        public static string test(string str1, string str2)
        {
            return str1 + str2 + str2 + str1;
        }




     static void Main(string[] args)
        {
            Console.WriteLine(test("[[]]", "Hello"));
            Console.WriteLine(test("(())", "Hi"));
            Console.ReadLine();
        }

        public static string test(string str1, string str2)
        {
            return str1.Substring(0, 2) + str2 + str1.Substring(2);
        }





    static void Main(string[] args)
        {
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Hi"));
            Console.ReadLine();
        }

        public static string test(string str1)
        {
            string string1 = str1.Substring (str1.Length - 2);
            return string1 + string1 + string1;
        }





    static void Main(string[] args)
        {
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Hi"));
            Console.WriteLine(test("H"));
            Console.WriteLine(test(" "));
            Console.ReadLine();
        }

        public static string test(string str1)
        {
            if (str1.Length > 1)
            {
                string string1 = str1.Substring(0 ,2);
                return string1;
            }
            return str1;
        }




    static void Main(string[] args)
        {
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Hi"));
            Console.ReadLine();
        }

        public static string test(string str1)
        {
                return str1.Substring(0, str1.Length /2);    
        }




    static void Main(string[] args)
        {
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Hi"));
            Console.WriteLine(test("Python"));

            Console.ReadLine();
        }

        public static string test(string str1)
        {
            return str1.Substring(1).Substring(0, str1.Length - 2);
        }




    static void Main(string[] args)
        {
            Console.WriteLine(test("Hello", "Hi"));
            Console.WriteLine(test("JS","Python"));
            Console.ReadLine();
        }

        public static string test(string str1,string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str1 + str2 + str1;
            }return str2 + str1 + str2;
        }




     static void Main(string[] args)
        {
            Console.WriteLine(test("Hello", "Hi"));
            Console.WriteLine(test("JS","Python"));
            Console.ReadLine();
        }

        public static string test(string str1,string str2)
        {
            return (str1.Substring(1))+( str2.Substring(1));
        }




    static void Main(string[] args)
        {
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("JS"));
            Console.ReadLine();
        }

        public static string test(string str1)
        {
            if (str1.Length > 2)
            {
                return str1.Remove(0,2) + str1.Substring(0,2);
            }
            return str1;
        }




    static void Main(string[] args)
        {
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("JS"));
            Console.ReadLine();
        }

        public static string test(string str1)
        {
            if (str1.Length > 2)
            {
                return str1.Substring(str1.Length -2) + str1.Remove(str1.Length -2);
            }
            return str1;
        }




    static void Main(string[] args)
        {
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("JS"));
            Console.WriteLine(test(" "));

            Console.ReadLine();
        }

        public static string test(string str1)
        {
            if (str1.Length > 1)
            {
                return str1.Substring(1, str1.Length - 2);
            }
            return " ";

        }





    static void Main(string[] args)
        {
            Console.WriteLine(test("Hell"));
            Console.WriteLine(test("JS"));

            Console.ReadLine();
        }

        public static string test(string str1)
        {
            if (str1.Length > 1)
            {
                return str1.Substring(str1.Length / 2 -1, 2);
            }
            return " ";
        }




    static void Main(string[] args)
        {
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("On"));
            Console.WriteLine(test("o"));


            Console.ReadLine();
        }

        public static bool test(string str1)
        {
            if (str1.ToLower().EndsWith("on"))
            {
                return true;
            }
            return false;
        }





    static void Main(string[] args)
        {
            Console.WriteLine(test("Hello", 1));
            Console.WriteLine(test("Python", 2));
            Console.WriteLine(test("On", 1));
            Console.WriteLine(test("o", 1));


            Console.ReadLine();
        }

        public static string test(string str1, int n)
        {
            return str1.Substring(0, n) + str1.Substring(str1.Length -n);
        }





    //*
    static void Main(string[] args)
        {
            Console.WriteLine(test("Hello", 1));
            Console.WriteLine(test("Python", 2));
            Console.WriteLine(test("On", 1));

            Console.ReadLine();
        }

        public static string test(string str1, int n)
        {
            if (n + 2 <= str1.Length)
            {
                return str1.Substring(n, 2);
            }return str1.Substring(0, 2);
        }




    // taking 3 chars from mid
    static void Main(string[] args)
        {
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("abc"));
            Console.WriteLine(test("AAAAASAAAAA"));


            Console.ReadLine();
        }

        public static string test(string str1)
        {
            return str1.Substring(str1.Length / 2 - 1, 3);
        }




    static void Main(string[] args)
        {
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("a"));
            Console.WriteLine(test(""));
            Console.ReadLine();
        }

        public static string test(string str1)
        {
            if (str1.Length > 1)
            {
                return str1.Substring(0,2);
            }
            else if (str1.Length == 0)
            {
                return "##";
            }
            return "#" + str1;
        }




  

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




static void Main(string[] args)
        {
            Console.WriteLine(test("abc", "cat"));
            Console.WriteLine(test("python", "php"));
            Console.WriteLine(test("php", "php"));
            Console.ReadLine();
        }

        public static string test(string str1, string str2)
        {
            if (str1.Substring(str1.Length - 1) == str2.Substring(0, 1))
            {
                return str1.Remove(str1.Length - 1) + str2;
            }
            return str1 + str2;
        }





    //replace last char and second last char with one and other.
            static void Main(string[] args)
        {
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("python"));
            Console.WriteLine(test("JS"));
            Console.WriteLine(test("C"));
            Console.ReadLine();
        }

        public static string test(string str1)
        {
            if (str1.Length > 1)
            {
                return str1.Substring(0, str1.Length - 2) + str1[str1.Length -1] + str1[str1.Length -2];
            }
            return str1;
        }






     static void Main(string[] args)
        {
            Console.WriteLine(test("abc"));
            Console.WriteLine(test("abcdef"));
            Console.WriteLine(test("C"));
            Console.WriteLine(test("xyz"));
            Console.WriteLine(test("xyzsder"));
            Console.ReadLine();
        }

        public static string test(string str1)
        {
            if (str1.ToLower().StartsWith("abc"))
            {
                return "abc";
            }
            else if (str1.ToLower().StartsWith("xyz"))
            {
                return "xyz";
            }
            return "";





    static void Main(string[] args)
        {
            Console.WriteLine(test("abab"));
            Console.WriteLine(test("abcdef"));
            Console.WriteLine(test("xyzsderxy"));
            Console.ReadLine();
        }

        public static bool test(string str1)
        {
            if (str1.Substring(0, 2) == str1.Substring(str1.Length -2))
            {
                return true;
            }return false;






     static void Main(string[] args)
        {
            Console.WriteLine(test("abc", "abcd"));
            Console.WriteLine(test("Python", "Python"));
            Console.WriteLine(test("JS", "Python"));
            Console.ReadLine();
        }

        public static string test(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str1.Substring(str1.Length - str2.Length) + str2;
            }
            else if (str1.Length < str2.Length)
            {
                return str1 + str2.Substring(str2.Length - str1.Length);
            }
            return str1 + str2;
        }






    static void Main(string[] args)
        {
            Console.WriteLine(test("abc"));
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("J"));
            Console.ReadLine();
        }

        public static string test(string str1)
        {
            string extra_Front = "";

            if (str1.Length < 2)
            {
                return str1 + str1 + str1;
            }
            else
            {
                extra_Front = str1.Substring(0, 2);
                return extra_Front + extra_Front + extra_Front;
            }





    static void Main(string[] args)
        {
            Console.WriteLine(test("abcab"));
            Console.WriteLine(test("Python"));
            Console.ReadLine();
        }

        public static string test(string str1)
        {
            if (str1.Substring(0,2) == str1.Substring(str1.Length -2))
            {
                return str1.Remove(0,2);
            }
            return str1;
        }






    static void Main(string[] args)
        {
            Console.WriteLine(test("abcab"));
            Console.WriteLine(test("python"));
            Console.WriteLine(test("press"));
            Console.WriteLine(test("jython"));
            Console.ReadLine();
        }

        public static string test(string str1)
        {
            if (str1.StartsWith("p") && str1.Substring(1,1) == "y")
            {
                return str1;
            }
            else if (str1.StartsWith("p"))
            {
                return str1.Substring(0,1) + str1.Remove(0, 2);
            }
            else if (str1.Substring(1, 1) == "y")
            {
                return str1.Remove(0, 1) ;
            }
            return str1.Remove(0,2);
        }





    static void Main(string[] args)
        {
            Console.WriteLine(test("abcab"));
            Console.WriteLine(test("python"));
            Console.WriteLine(test("abcda"));
            Console.WriteLine(test("jython"));
            Console.ReadLine();
        }

        public static string test(string str1)
        {
            if (str1.StartsWith("a") && str1.Substring(str1.Length -1) == "a")
            {
                return str1.Remove(str1.Length - 1).Remove(0,1);
            }
            else if (str1.StartsWith("a"))
            {
                return str1.Remove(0, 1);
            }
            else if (str1.Substring(str1.Length -1) == "a")
            {
                return str1.Remove(str1.Length -1);
            }
            return str1;





     static void Main(string[] args)
        {
            Console.WriteLine(test("abcab"));
            Console.WriteLine(test("python"));
            Console.WriteLine(test("aacda"));
            Console.WriteLine(test("jython"));
            Console.ReadLine();
        }

        public static string test(string str1)
        {
            if (str1.StartsWith("aa"))
            {
                return str1.Remove(0,2);
            }
            else if (str1.StartsWith("a"))
            {
                return str1.Remove(0, 1);
            }
            return str1;




    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 10, 20, 40, 50 }));
            Console.WriteLine(test(new[] { 5, 20, 40, 10 }));
            Console.WriteLine(test(new[] { 10, 20, 40, 10 }));
            Console.WriteLine(test(new[] { 12, 24, 35, 55 }));
        }

        public static bool test(int[] nums)
        {
            return nums[0] == 10 || nums[nums.Length - 1] == 10;
        }




    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 10, 20, 40, 50 }));
            Console.WriteLine(test(new[] { 10, 20, 40, 10 }));
            Console.WriteLine(test(new[] { 12, 24, 35, 55 }));
        }

        public static bool test(int[] nums)
        {
            return nums[0] ==  nums[nums.Length - 1];
        }





     static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 10, 20, 40, 50 }, new[] { 10, 20, 40, 50 }));
            Console.WriteLine(test(new[] { 10, 20, 40, 50 }, new[] { 10, 20, 40, 5 }));
            Console.WriteLine(test(new[] { 10, 20, 40, 50 }, new[] { 1, 20, 40, 5 }));
            Console.ReadLine();
        }

        public static bool test(int[] num1, int[] num2)
        {
            if (num1[0] == num2[0] || num1[num1.Length - 1] == num2[num2.Length - 1])
            {
                return true;
            }
            return false;
        }





    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 10, 20, 30, 40, 50 }));
            Console.WriteLine(test(new[] { 10, 20, -30, -40, 50 }));
            Console.ReadLine();
        }

        public static int test(int[] num1)
        {
            return num1.Sum();
        }





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





static void Main(string[] args)
        {
            int[] item = test(new[] { 10, 20, -30, -40, 50 });

            Console.Write("Reverse array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] nums)
        {
            return new int[] { nums[4], nums[3], nums[2], nums[1], nums[0] };
        }




    static void Main(string[] args)
        {
            int[] item = test(new[] { 10, 20, -30, -40 });

            Console.Write("New array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] nums)
        {
            int max = nums.Max();
            return new int[] { max, max, max, max };
        }




    static void Main(string[] args)
        {
            int[] item = test(new[] { 10, 20, -30, -40, 30 }, new[]{ 10, 20, 30 ,40, 30});

            Console.Write("New array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] nums1, int[] num2)
        {
            return new int[] { nums1[2], num2[2] };
        }





    static void Main(string[] args)
        {
            int[] item = test(new[] { 10, 20, -30, -40, 30 });

            Console.Write("New array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] num1)
        {
            return new int[] { num1[0], num1[num1.Length -1] };
        }





    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 12, 20 }));
            Console.WriteLine(test(new[] { 14, 15 }));
            Console.WriteLine(test(new[] { 11, 21 }));
        }

        public static bool test(int[] num1)
        {
            return num1[0] == 15 || num1[0] == 20 || num1[1] == 15 || num1[1] == 20;
        }





     static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 12, 20 }));
            Console.WriteLine(test(new[] { 14, 15 }));
            Console.WriteLine(test(new[] { 11, 21 }));
        }

        public static bool test(int[] num1)
        {
            return num1[0] != 15 && num1[0] != 20 && num1[1] != 15 && num1[1] != 20;
        }





    //**
    static void Main(string[] args)
        {
            int[] item = test(new[] { 10, 20, -30, -40, 30 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] num1)
        {
            int elemets = num1.Length * 2;
            int[] doubleNums = new int[elemets];

            doubleNums[0] = num1[0];
            return doubleNums;
        }




    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 12, 20 }));
            Console.WriteLine(test(new[] { 20, 20 }));
            Console.WriteLine(test(new[] { 10, 10 }));
            Console.WriteLine(test(new[] { 10 }));
        }

        public static bool test(int[] nums)
        {
            if (nums.Length > 1 && (nums[0] == 10 && nums[1] == 10) || (nums[0] == 20 && nums[1] == 20))
            {
                return true;
            }
            return false;
        }




    static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 5, 7 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] nums)
        {
            for (int i = 0; i < nums.Length -1 ; i++)
            {
                if (nums[i] == 5 && nums[i + 1] == 7)
                {
                    nums[i + 1] = 1;
                }
            }
            return nums;
        }





    static void Main(string[] args)
        {
            int[] item = test(new[] { 10, 20, -30 }, new[] { 10, 20, 30 });
            Console.Write("Larger array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] num1, int[] num2)
        {
            if (num1[0] + num1[1] + num2[2] >= num2[0] + num2[1] + num2[2])
            {
                return num1;
            }
            return num2;
        }




    static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 5, 7, 9, 11, 13 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] num1)
        {
            return new int[] {num1[num1.Length / 2 -1], num1[num1.Length / 2]};
        }




    static void Main(string[] args)
        {
            int[] item = test(new[] { 10, 20, 30 }, new[] { 40, 50, 60 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] num1, int[] num2)
        {
            return new int[] {num1[0], num1[1], num1[2], num2[0], num2[1], num2[2]};
        }




    static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 5, 7, 9, 11, 13 });
            Console.Write("After swapping first and last elements: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] nums)
        {
            int first = nums[0];
            nums[0] = nums[nums.Length - 1];
            nums[nums.Length - 1] = first;

            return nums;
        }





    //**
    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1 }));
            Console.WriteLine(test(new[] { 1, 2, 9 }));
            Console.WriteLine(test(new[] { 1, 2, 9, 3, 3 }));
            Console.WriteLine(test(new[] { 1, 2, 3, 4, 5, 6, 7 }));
            Console.WriteLine(test(new[] { 1, 2, 2, 3, 7, 8, 9, 10, 6, 5, 4 }));
        }

        public static int test(int[] nums)
        {
            int first, middle, last, max;
            first = nums[0];
            middle = nums[nums.Length / 2];
            last = nums[nums.Length - 1];
            max = first;

            if (middle > max)
            {
                max = middle;
            }
            if (last > max)
            {
                max = last;
            }
            return max;




    //**
     static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 5, 7, 9, 11, 13 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] nums)
        {
            int[] frontNum;
            if (nums.Length >= 2)
            {
                frontNum = new int[] { nums[0], nums[1] };
            }
            else if (nums.Length > 0)
            {
                frontNum = new int[] { nums[0] };
            }
            else
            {
                frontNum = new int[0];
            }
            return frontNum;
        }





     static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 5, 7, 9, 10, 12 }));
        }

        public static int test(int[] nums)
        {
            int even = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    even++;
                }
            }return even;
        }






    //**
    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 5, 7, 9, 10, 12 }));
        }

        public static int test(int[] nums)
        {
            int smallNum = 0, bigNum = 0;
            if (nums.Length > 0)
            {
                smallNum = bigNum = nums[0];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                smallNum = Math.Min(smallNum, nums[i]);
                bigNum = Math.Max(bigNum, nums[i]);
            }return bigNum - smallNum;
        }





    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 5, 7, 9, 10, 17 }));
        }

        public static int test(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 17)
                {
                    sum += nums[i];
                }
            }
                return sum;
        }






    //*
     static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 5, 6, 1, 5, 6, 9, 10, 17, 5, 6 }));
            Console.WriteLine(test(new[] { 5, 6, 1, 5, 6, 9, 10, 17 }));
            Console.WriteLine(test(new[] { 1, 5, 6, 9, 10, 17, 5, 6 }));
            Console.WriteLine(test(new[] { 1, 5, 9, 10, 17, 5, 6 }));
            Console.WriteLine(test(new[] { 1, 5, 9, 10, 17, 5 }));
        }

        public static int test(int[] nums)
        {
            int sum = 0;
            int inSection = 0;
            int flag = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                inSection = 0;
                if (nums[i] == 5)
                {
                    inSection = 0;
                    flag = 1;
                }
                if (inSection == 0 && nums[i] == 6)
                {
                    if (flag == 1)
                    {
                        sum = sum - 5;
                        inSection = 1;
                    }
                    flag = 0;
                }
                if (inSection == 0)
                {
                    sum += nums[i];
                }
            }
            return sum;
        }





    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 5, 6, 9, 10, 17 }));
            Console.WriteLine(test(new[] { 1, 5, 5, 9, 10, 17 }));
            Console.WriteLine(test(new[] { 1, 5, 5, 9, 10, 17, 5, 5 }));
        }

        public static bool test(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 5 && nums[i + 1] == 5)
                {
                    return true;
                }
            }
            return false;
        }





    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 5, 6, 9, 10, 17 }));
            Console.WriteLine(test(new[] { 1, 4, 7, 9, 10, 17 }));
            Console.WriteLine(test(new[] { 1, 1, 2, 9, 10, 17}));
        }

        public static bool test(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 5 || nums[i] == 7)
                {
                    return true;
                }
            }
            return false;
        }





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





    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 5, 6, 9, 3, 3 }));
            Console.WriteLine(test(new[] { 1, 5, 5, 5, 10, 17 }));
            Console.WriteLine(test(new[] { 1, 3, 3, 5, 5, 5 }));
        }

        public static bool test(int[] nums)
        {
            int num3 = 0, num5 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 3)
                {
                    num3++;
                }
                if (nums[i] == 5)
                {
                    num5++;
                }
            }
            return num3 > num5;





     static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 5, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 3, 3, 3, 3 }));
            Console.WriteLine(test(new[] { 3, 3, 3, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 1, 6, 8, 10 }));
        }

        public static bool test(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 3 || nums[i] == 5)
                {
                    return true;
                }
            }
            return false;
        }






    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 5, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 3, 3, 3, 3 }));
            Console.WriteLine(test(new[] { 3, 3, 3, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 1, 6, 8, 10 }));
        }

        public static bool test(int[] nums)
        {
            var three = false;
            var five = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 3)
                {
                    three = true;
                }
                if (nums[i] == 5)
                {
                    five = true;
                }
                if (three && five)
                {
                    return false;
                }
            }
            return true;
        }






     static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 5, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(test(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 1, 5, 5, 7, 8, 10 }));
        }

        public static bool test(int[] nums)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] == 3 && nums[i + 1] == 3) ||(nums[i] == 5 && nums[i + 1] == 5))
                {
                    return true;
                }
            }
            return false;



     


    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 5, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(test(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 1, 5, 5, 7, 8, 10 }));
        }

        public static bool test(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 5 && nums[i + 1] == 5)
                {
                    return true;
                }
                if (nums[i] == 5 && nums[i + 2] == 5)
                {
                    return true;
                }
            }
            return false;
        }





static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 5, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(test(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 1, 5, 5, 7, 8, 10 }));
        }

        public static bool test(int[] nums)
        {
            int oddNum = 0, evenNum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (oddNum < 2 && evenNum < 2)
                {
                    if (nums[i] % 2 == 0)
                    {
                        evenNum++;
                        oddNum = 0;
                    }
                    else
                    {
                        oddNum++;
                        evenNum =0;
                    }
                }
            }
            return oddNum == 2|| evenNum == 2;






     static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 3, 5, 1, 5, 3, 5, 7, 5, 1, 5 }));
            Console.WriteLine(test(new[] { 3, 5, 5, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 3, 5, 2, 5, 4, 5, 7, 5, 8, 5 }));
            Console.WriteLine(test(new[] { 2, 4, 5, 5, 5, 5 }));
        }

        public static bool test(int[] nums)
        {
            bool flag = false;
            int five = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 5 && !flag)
                {
                    five++;
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            return five == 5;





    //**
    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 3, 5, 5, 3, 7 }));
            Console.WriteLine(test(new[] { 3, 5, 5, 4, 1, 5, 7 }));
            Console.WriteLine(test(new[] { 3, 5, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 2, 4, 5, 5, 6, 7, 5 }));
        }

        public static bool test(int[] nums)
        {
            bool flag = true;
            int arrayLen = nums.Length;

            for (int i = 0; i < arrayLen; i++)
            {
                if (nums[i] == 5)
                {
                    if ((i > 0 && nums[i - 1] == 5) || (i < arrayLen - 1 && nums[i + 1] == 5))
                    {
                        flag = true;
                    }
                    else return false;
                }
            }
            return flag;
        }





    //**
    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 3, 7, 5, 5, 3, 7 }, 2));
            Console.WriteLine(test(new[] { 3, 7, 5, 5, 3, 7 }, 3));
            Console.WriteLine(test(new[] { 3, 7, 5, 5, 3, 7, 5 }, 3));
        }

        public static bool test(int[] nums, int len)
        {
            for (int i = 0; i < len; i++)
            {
                if (nums[i] == nums[nums.Length - len + i])
                {
                    return true;
                }
            }return false;
        }





    //**
     static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 2, 3, 5, 3, 7 }));
            Console.WriteLine(test(new[] { 3, 7, 5, 5, 3, 7 }));
            Console.WriteLine(test(new[] { 3, 7, 5, 5, 6, 7, 5 }));
        }

        public static bool test(int[] nums)
        {
            for (int i = 0; i <= nums.Length - 3; i++)
            {
                if (nums[i] == nums[i + 1] - 1 && nums[i] == nums[i + 2] - 2)
                {
                    return true;
                }
            }return false;
        }





    //**
     static void Main(string[] args)
        {
            int[] item = test(new[] { 10, 20, -30, -40, 50 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] nums)
        {
            int size = nums.Length;
            int[] shiftNums = new int[size];

            for (int i = 0; i < size; i++)
            {
                shiftNums[i] = nums[(i + 1) % size];
            }
            return shiftNums;
        }




    //**
    static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 2, 3, 5, 7 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] nums)
        {
            int size = 0;
            int[] pre5;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 5)
                {
                    size = i;
                    break;
                }
            }
            pre5 = new int[size];
            for (int i = 0; i < size; i++)
            {
                pre5[i] = nums[i];
            }return pre5;
        }






    //**
     static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 2, 3, 5, 7,9,11 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] nums)
        {
            int len = nums.Length, size = 0, i = len - 1;
            int[] post5;

            while (i >= 0 && nums[i] != 5) i--;
            i++;

            size = len - i;
            post5 = new int[size];

            for (int j = 0; j < size; j++)
            {
                post5[j] = nums[i + j];
            }
            return post5;
        }





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






    static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 2, 5, 3, 5, 7, 5, 9, 11 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] nums)
        {
            int size = nums.Length, index = 0;
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                if (nums[i] != 5)
                {
                    array[index] = nums[i];
                }
            }return array;



     


    static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 2, 5, 3, 5, 4, 6, 9, 11 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] nums)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    nums[index] = nums[i];
                    nums[i] = nums[index];
                    index++;
                }
            }return nums;
        }






    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 5, 5, 1, 5, 5 }));
            Console.WriteLine(test(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(test(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 1, 5, 5, 7, 8, 10 }));
        }

        public static bool test(int[] nums)
        {
            for (int i = 0; i < nums.Length -1 ; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    return false;
                }
            }return true;
        }





    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 5, 5, 1, 15, 15 }));
            Console.WriteLine(test(new[] { 15, 2, 3, 4, 15 }));
            Console.WriteLine(test(new[] { 3, 3, 15, 15, 5, 5 }));
            Console.WriteLine(test(new[] { 1, 5, 15, 7, 8, 15 }));
        }

        public static bool test(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1 ; i++)
            {
                if (nums[i + 1] == nums[i] && nums[i] == 15 )
                {
                    return true;
                }
            }return false;
        }






    //**
    static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 2, 3, 4, 6, 8 }));
            Console.WriteLine(test(new[] { 15, 2, 3, 4, 15, 11 }));
        }

        public static int test(int[] numbers)
        {
            var firstHalf = Average(numbers, 0, numbers.Length / 2);
            var secondHalf = Average(numbers, numbers.Length / 2, numbers.Length);
            if (firstHalf > secondHalf)
            {
                return firstHalf;
            }return secondHalf;
        }
        static int Average(int[] num, int start, int end)
        {
            var sum = 0;
            for (int i = start; i < end; i++)
            {
                sum += num[i];
            }
                return sum / (num.Length / 2);
        }






     static void Main(string[] args)
        {
            Console.WriteLine("Number of Strings: ");
            Console.WriteLine(test(new[] { "a", "b", "bb", "c", "ccc" }, 1));
        }

        public static int test(string[] arrayStr, int len)
        {
            int counter = 0;
            for (int i = 0; i < arrayStr.Length; i++)
            {
                if (arrayStr[i].Length == len)
                {
                    counter++;
                }
            }return counter;
        }





    static void Main(string[] args)
        {
            string[] item = test(new[] { "a", "b", "bb", "c", "ccc" }, 3);
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static string[] test(string[] arrayStr, int n)
        {
            string[] newArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                newArray[i] = arrayStr[i];
            }return newArray;
        }





    //**
    static void Main(string[] args)
        {
            ArrayList item = test(new[] { "a", "aaa","b", "bbb", "c", "ccc" }, 3);
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static ArrayList test(string[] arrayStr, int n)
        {
            ArrayList resultArray = new ArrayList();
            for (int i = 0; i < arrayStr.Length; i++)
            {
                if (arrayStr[i].Length == n)
                {
                    resultArray.Add(arrayStr[i]);
                }
            }return resultArray;
        }





    static void Main(string[] args)
        {
            Console.WriteLine(test(123));
            Console.WriteLine(test(13));
            Console.WriteLine(test(222));
        }

        public static bool test(int n)
        {
            while (n > 0)
            {
                if (n % 10 == 2)
                {
                    return true;
                }
                n /= 10;
            }return false;
            
        }




    //**
    static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 2, 3, 5, 7, 9, 10 }, 3);
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] nums, int count)
        {
            int[] evens = new int[count];
            int j = 0;
            for (int i = 0; j < count; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    evens[j] = nums[i];
                    j++;
                }
            }
            return evens;
        }




    //**
     static void Main(string[] args)
        {
            List<int> mylist = test(new List<int>(new int[] { 1, 2, 3, 4 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static List<int> test(List<int> nums)
        {
            IEnumerable<int> doubled = nums.Select(x => x *= 3);
            return doubled.ToList<int>();
        }






    static void Main(string[] args)
        {
            List<int> mylist = test(new List<int>(new int[] { 1, 2, 3, 4 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static List<int> test(List<int> nums)
        {
            IEnumerable<int> squared = nums.Select(x => x * x * x);
            return squared.ToList<int>();
        }





    static void Main(string[] args)
        {
            List<string> mylist = test(new List<string>(new string[] { "1", "2", "3", "4" }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static List<string> test(List<string> str)
        {
            IEnumerable<string> s = str.Select(x => "#" + x + "#");
            return s.ToList();
        }






     static void Main(string[] args)
        {
            List<string> mylist = test(new List<string>(new string[] { "1", "2", "3", "4" }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static List<string> test(List<string> str)
        {
            IEnumerable<string> s = str.Select(x => x = x + x + x + x);
            return s.ToList();
        }






    static void Main(string[] args)
        {
            List<int> mylist = test(new List<int>(new int[] { 1, 2, 3, 4 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static List<int> test(List<int> num)
        {
            IEnumerable<int> s = num.Select(x => 5 * (x + 2));
            return s.ToList();
        }





     static void Main(string[] args)
        {
            List<int> mylist = test(new List<int>(new int[] { 10, 22, 35, 41 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static List<int> test(List<int> num)
        {
            IEnumerable<int> s = num.Select(x => x % 10);
            return s.ToList();
        }





static void Main(string[] args)
        {
            List<string> mylist = test(new List<string>(new string[] { "Abc", "cdef", "js", "php" }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static List<string> test(List<string> str)
        {
            IEnumerable<string> s = str.Select(x => x.ToUpper());
            return s.ToList();
        }





    static void Main(string[] args)
        {
            List<string> mylist = test(new List<string>(new string[] { "abc", "cdaef", "js", "php" }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static List<string> test(List<string> str)
        {
            return str.Select(x => x.Replace("a","")).ToList();
        }




    //**
static void Main(string[] args)
        {
            List<int> mylist = test(new List<int>(new int[] { 0, -2, 1, 2, 3, 5, 4, 7, 8 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static List<int> test(List<int> nums)
        {
            return nums.Where(n => n < 4).ToList();
        }





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




    */
}
