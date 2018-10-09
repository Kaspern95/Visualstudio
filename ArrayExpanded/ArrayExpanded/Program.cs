using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExpanded
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Opg7_9();
            //Opg7_10();
            //Opg7_11();
            //Opg7_12();

            
            Console.ReadLine();
        }

        private static void Opg7_12()
        {
            int[,] mit2DArray = new int[2, 2];
            mit2DArray[0, 0] = 7;
            mit2DArray[1, 0] = 5;
            mit2DArray[0, 1] = 12;
            mit2DArray[1, 1] = 34;

            Console.WriteLine("Indtast et nummer i 2D array");
            string read = Console.ReadLine();
            int search = int.Parse(read);
            Contains(mit2DArray, search);
        }

        private static int[,] Contains(int[,] newArray, int search)
        {
            bool exists = false;
            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                if (newArray[i, j] == search)
                {
                    exists = true;
                        Console.WriteLine($"{search} number does exist in the array");
                }
                    

                }
            }
            if (exists == false)
            {
                Console.WriteLine($"{search} does not exist");
            }
            return newArray;
        }

        private static void Opg7_11()
        {
            int[] array = new int[100];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(101);
            }
            int[] newArray = ArrayChange(array);
        }

        private static int[] ArrayChange(int[] intArray)
        {
            Array.Resize(ref intArray, 105);
            return intArray;
        }

        private static void Opg7_10()
        {
            int[] array1 = new int[2] { 5, 10 };
            int[] array2 = new int[3] { 5, 10, 15 };
            int resultat = Add(array1, array2);
        }

        private static int Add(int[] arrayX, int[] arrayY)
        {
            int arrayXLength = arrayX.Length;
            int arrayYLength = arrayY.Length;
            int x = 0;
            int y = 0;

            for (int i = 0; i < arrayXLength; i++)
            {
                x += arrayX[i];
            }
            for (int i = 0; i < arrayYLength; i++)
            {
                y += arrayY[i];
            }
            int resultat = x + y;
            return resultat;
        }

        private static void Opg7_9()
        {
            Console.WriteLine("Opgave 7.9");
            for (int i = 0; i < 10; i++)
            {

                int tal = 1;
                for (; tal < 11; tal++)
                {
                    Console.WriteLine(tal);
                }
                for (tal = 10; tal > 0; tal--)
                {
                    Console.WriteLine(tal);
                }
                Console.WriteLine($"Omgang nr: {i + 1}");
            }
        }
    }
}
