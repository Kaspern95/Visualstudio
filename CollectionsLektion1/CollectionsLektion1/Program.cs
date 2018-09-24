using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLektion1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region skoleeksempel
            int[] intArray = new int[10] ;
            intArray[2] = 5;

            string[] stringArray = new string[5];
            stringArray[0] = "2";

            //Use char array to find letters in strings
            string navn = "Kasper";
            char test = navn[1];
            #endregion

            int[] medarbejder = LavEtArray(15);


            Console.WriteLine("Opgave 5");
            int[] myArray = new int[5] {10, 20, 30, 40 ,50 };
            Console.WriteLine(myArray[2]);
            Console.WriteLine(myArray[4]);


            Console.WriteLine("Opgave 5.1");
            int tal1;
            int tal2;
            int tal3;
            int tal4;
            int tal5;
            tal1 = int.Parse(Console.ReadLine());
            tal2 = int.Parse(Console.ReadLine());
            tal3 = int.Parse(Console.ReadLine());
            tal4 = int.Parse(Console.ReadLine());
            tal5 = int.Parse(Console.ReadLine());

            int[] newArray = new int[5] { tal1, tal2, tal3, tal4, tal5, };
            Console.Clear();
            
            if( tal1 > 0 && tal1 < 100)
            {
                Console.WriteLine(newArray[0]);
            }
            else
            {
                Console.WriteLine("Prøv igen");
                tal1 = int.Parse(Console.ReadLine());
            }
            if ( tal2 > 0 && tal2 < 100)
            {
                Console.WriteLine(newArray[1]);
            }
            else
            {
                Console.WriteLine("Prøv igen");
                tal2 = int.Parse(Console.ReadLine());
            }
            if ( tal3 > 0 && tal3 < 100)
            {
                Console.WriteLine(newArray[2]);
            }
            else
            {
                Console.WriteLine("Prøv igen");
                tal3 = int.Parse(Console.ReadLine());
            }
            if ( tal4 > 0 && tal4 < 100)
            {
                Console.WriteLine(newArray[3]);
            }
            else
            {
                Console.WriteLine("Prøv igen");
                tal4 = int.Parse(Console.ReadLine());
            }
            if ( tal5 > 0 && tal5 < 100)
            {
                Console.WriteLine(newArray[4]);
            }
            else
            {
                Console.WriteLine("Prøv igen");
                tal5 = int.Parse(Console.ReadLine());
            }

            

            
            Console.ReadLine();

            Console.WriteLine("Opgave 5.2");
        }
        static int[] LavEtArray(int size)
        {
            int[] testArray = new int[size];
            return testArray;
        }
        
    }
}
