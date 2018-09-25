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
            Console.WriteLine(myArray[2] +" og "+ myArray[4]);

            /*
            #region 5.1
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

            #endregion
            */
            Console.WriteLine("5.1 v2");
            

            int[] mitArray = LavMitArray(5);
            PrintMitArray(mitArray);
            PlusAlleIndexer(mitArray);
            int res = PlusAlleIndexer(mitArray);
            PrintResultat(res);

            Console.ReadLine();

            Console.WriteLine("Opgave 5.2");
        }
        static void PrintResultat(int res)
        {
            Console.WriteLine("Dit resultat er: ");
            Console.WriteLine(res);
        }
        static void PrintMitArray(int[] arrayToPrint)
        {
            Console.WriteLine(arrayToPrint[0]);
            Console.WriteLine(arrayToPrint[1]);
            Console.WriteLine(arrayToPrint[2]);
            Console.WriteLine(arrayToPrint[3]);
            Console.WriteLine(arrayToPrint[4]);
        }
        static int[] LavMitArray(int size)
        {
            int[] localArray;
            localArray = new int[size];
            localArray[0] = InputMellemNulOgHundrede();
            localArray[1] = InputMellemNulOgHundrede();
            localArray[2] = InputMellemNulOgHundrede();
            localArray[3] = InputMellemNulOgHundrede();
            localArray[4] = InputMellemNulOgHundrede();
            
            return localArray;
        }
        static int PlusAlleIndexer(int[] arrayToAdd)
        {
            int resultat = arrayToAdd[0] + arrayToAdd[1] + arrayToAdd[2] + arrayToAdd[3] + arrayToAdd[4];
            return resultat;
        }
        private static int InputMellemNulOgHundrede()
        {
            Console.WriteLine("Indtast et tal mellem 1 og 100");
            int tal1 = int.Parse(Console.ReadLine());
            if (tal1 >= 1 && tal1 <= 100)
            {
                return tal1;
            }
            else
            {
                Console.WriteLine("Forkert input, 1-100 only");
                return -1;
            }
        }

        static int[] LavEtArray(int size)
        {
            int[] testArray = new int[size];
            return testArray;
        }
        
    }
}
