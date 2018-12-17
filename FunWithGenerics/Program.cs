using System.Collections.Generic;

namespace FunWithGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myStrings = new List<string>();
            GenericList<int> intList = new GenericList<int>();
            intList.Add(10);
            int[] mangeTal = new int[5] { 1, 2, 3, 4, 5 };
            Swap(ref mangeTal[1], ref mangeTal[3]);
        }

        public static void Swap<T>(ref T l, ref T r)
        {
            T temp;
            temp = l;
            l = r;
            r = temp;
        }
    }
}
