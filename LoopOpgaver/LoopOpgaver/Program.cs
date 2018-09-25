using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopOpgaver
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave 6");

            //WhileLoop6();

            Console.WriteLine("6.1");

            DoWhileLoop6();

            Console.WriteLine("hjkasd");
            Console.ReadLine();
        }

        private static void DoWhileLoop6()
        {
            int[] intArray = new int[100];
            int cap = 0;
            bool erDetSandt = true;
            
            do
            {
                int number = rnd.Next(1001);
                if ((number % 10) == 0 && cap < intArray.Length)
                {
                    Console.WriteLine(number);
                    cap++;
                }
                else if (cap >= intArray.Length)
                {
                    erDetSandt = false;
                }
                else
                {
                    cap++;
                }
            } while (erDetSandt);
                
        }

        private static void WhileLoop6()
        {
            int[] intArray = new int[20];
            int cap = 0;
            while (true && cap < intArray.Length)
            {
                int number = rnd.Next(101);
                Console.WriteLine(number);
                cap++;
            }
        }

    }
}
