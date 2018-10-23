using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Input the desired number of rows: ");
            int antalRaekker = int.Parse(Console.ReadLine());
            int[] array1 = new int[7];
            for (int i = 0; i < antalRaekker; i++)
            {
                Console.Write($"{i+1,2}");
                for (int j = 0; j < array1.Length; j++)
                {
                    array1[j] = rnd.Next(1, 37);
                }
                foreach (var item in array1)
                {
                    Array.Sort(array1);
                    Console.WriteLine($"{item:d2} ");


                }
            }
            Console.ReadLine();
        }
    }
}
