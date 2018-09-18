using System;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("** fun with methods **");
            /*
            int x = 9, y = 10;
            Console.WriteLine($"before call: X: {x}, Y: {y}");
            Console.WriteLine($"Answer is: {Add(x,y)}");
            Console.WriteLine($"after call: X: {x}, Y: {y}");
            Add(90, 90, out int ans);
            Console.WriteLine($"90+90 = {ans}");
            Console.WriteLine();

            int i; string str; bool b;
            FillTheseValues(out i, out str, out b);
            Console.WriteLine($"int is {i}");
            Console.WriteLine($"str is {str}");
            Console.WriteLine($"bool is {b}");
            
            string str1 = "flip";
            string str2 = "flop";
            Console.WriteLine($"before:{str1},{str2}");
            

            SwapStrings(ref str1, ref str2);
            Console.WriteLine($"after:{str1},{str2}");
            */

            Console.ReadLine();

        }
        static int Add(int x, int y)
        {
            int ans = x + y;
            x = 10000;
            y = 88888;
            return ans;
        }
        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }
        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "string";
            c = true;
        }
        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }
        public static string SimpleReturn(string[] strArray, int position)
        {
            return strArray[position];
        }
    }
}
