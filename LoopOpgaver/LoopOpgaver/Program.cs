using System;

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

            //DoWhileLoop6();

            Console.WriteLine("6.2");

            //ForLoop6();

            Console.WriteLine("6.3");

            //Opg6_3();

            Console.WriteLine("6.4");

            //opg6_4();

            Console.WriteLine("6.5");

            Opg6_5();


            Console.WriteLine("dansgame");
            Console.ReadLine();
        }

        private static void Opg6_5()
        {
            int antal = 0;
            do
            {

                int terning1 = rnd.Next(1, 7);
                int terning2 = rnd.Next(1, 7);
                int terning3 = rnd.Next(1, 7);
                int terning4 = rnd.Next(1, 7);
                int terning5 = rnd.Next(1, 7);
                int terning6 = rnd.Next(1, 7);
                string slag = $"{terning1}{terning2}{terning3}{terning4}{terning5}{terning6}";

                if (terning1 == terning2 && terning2 == terning3 && terning3 == terning4 && terning4 == terning5 && terning5 == terning6)
                {
                    Console.WriteLine(slag);
                    Console.WriteLine(antal);   
                    break;

                }
                else
                {
                    antal++;
                }
                
                
            } while (true);



        }

        private static void opg6_4()
        {
            string spg;
            bool check = true;
            do
            {
                Console.WriteLine("indtast film");
                string film = Console.ReadLine();
                Console.WriteLine("indtast instruktor");
                string instruktor = Console.ReadLine();
                Console.WriteLine("indtast genrer");
                string genrer = Console.ReadLine();
                Console.WriteLine("Afslut program (ja/nej:)");
                spg = Console.ReadLine();

                bool rigtig = true;
                do
                {
                    Console.WriteLine("indtast stjerner");
                    int stjerner = int.Parse(Console.ReadLine());
                    if (stjerner < 11 || stjerner >= 0)
                    {
                        rigtig = false;
                    }

                } while (rigtig);
                if (spg == "ja" || spg == "Ja" || spg == "JA" || spg == "jA")
                {

                    check = false;
                }
                else
                {

                }

            } while (check);
        }

        private static void Opg6_3()
        {
            string spg;
            bool check = true;
            do
            {
                Console.WriteLine("indtast film");
                string film = Console.ReadLine();
                Console.WriteLine("indtast instruktor");
                string instruktor = Console.ReadLine();
                Console.WriteLine("indtast genrer");
                string genrer = Console.ReadLine();
                Console.WriteLine("indtast stjerner");
                int stjerner = int.Parse(Console.ReadLine());
                Console.WriteLine("Afslut program (ja/nej:)");
                spg = Console.ReadLine();
                if (spg == "ja" || spg == "Ja" || spg == "JA" || spg == "jA")
                {
                    check = false;
                }
                else
                {

                }

            } while (check);
        }

        private static void ForLoop6()
        {
            int total = 0;
            for (int i = 0; i < 500; i++)
            {
                int number = rnd.Next(1, 7);
                total += number;

            }
            double gennemsnit = (double)total / 500;
            Console.WriteLine("Det gennemsnitlige nummer: {0}", gennemsnit);

        }

        private static void DoWhileLoop6()
        {
            int[] intArray = new int[100];
            int cap = 0;
            bool erDetSandt = true;
            int i = 0;
            do
            {
                int number = rnd.Next(1001);
                cap++;
                if ((number % 10) == 0 && cap < intArray.Length)
                {
                    Console.WriteLine(number);

                }
                else if (cap >= intArray.Length)
                {
                    erDetSandt = false;
                }
                else
                {

                    Console.WriteLine(i++);
                }

            } while (erDetSandt);
            Console.WriteLine(cap - i);

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
