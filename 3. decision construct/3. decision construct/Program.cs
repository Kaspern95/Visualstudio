using System;

namespace _3.decision_construct
{
    class Program
    {

        static Random rnd = new Random();
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Opgave 3");
            double temperatur;
            Console.WriteLine("Hvad er temperaturen?");
            temperatur = double.Parse(Console.ReadLine());
            if (temperatur >= 20)
            {
                Console.WriteLine("Fantastisk vejr");
            }
            else
            {
                Console.WriteLine("Så kender man det danske vejr!");
            }
            Console.WriteLine();

            Console.WriteLine("Opgave 3.1");
            double temperatur1;
            Console.WriteLine("Hvad er temperaturen?");
            temperatur1 = double.Parse(Console.ReadLine());
            if (temperatur1 == 20)
            {
                Console.WriteLine("Ganske udemærket vejr");
            }
            else if (temperatur1 > 20)
            {
                Console.WriteLine("Det er vist sommeren 2018!");
            }
            else
            {
                Console.WriteLine("Så kender man det danske vejr");
            }
            Console.WriteLine();

            Console.WriteLine("Opgave 3.2");
            Console.WriteLine("Hvad er temperaturen?");
            double temperatur2 = double.Parse(Console.ReadLine());
            if (temperatur2 > 20)
            {
                Console.WriteLine("Du er draget sydpå");
            }
            else if (temperatur2 == 0)
            {
                Console.WriteLine("at the poles!");
            }
            else if (temperatur2 > 0 && temperatur < 20)
            {
                Console.WriteLine("Hjemme i danmark");
            }
            Console.WriteLine();

            Console.WriteLine("Opgave 3.3");
            Console.WriteLine("Indtast et måneds nr.");
            int seasonNr = int.Parse(Console.ReadLine());
            if (seasonNr == 1 || seasonNr == 2 || seasonNr == 12)
            {
                Console.WriteLine("Its winter!");
            }
            else if (seasonNr == 3 || seasonNr == 4 || seasonNr == 5)
            {
                Console.WriteLine("Its spring!");
            }
            else if (seasonNr == 6 || seasonNr == 7 || seasonNr == 8)
            {
                Console.WriteLine("Its summer!");
            }
            else if (seasonNr == 9 || seasonNr == 10 || seasonNr == 11)
            {
                Console.WriteLine("Its autumn   !");
            }
            else
            {
                Console.WriteLine("That is not a month of the year");
            }
            Console.WriteLine();
            
            Console.WriteLine("Opgave 3.4");
            Console.WriteLine("Gæt et tal mellem 1-10");
            int guess = int.Parse(Console.ReadLine());
            int i = rnd.Next(1, 11);
            if (guess == i)
            {
                Console.WriteLine(i);
                Console.WriteLine("Du gættede rigtigt!");
            }
            else
            {
                Console.WriteLine(i);
                Console.WriteLine("Du gættede forkert.");
            }
            Console.WriteLine();

            Console.WriteLine("Opgave 3.5");
            Console.WriteLine("Indtast målestoksforhold i cm");
            double tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{tal1} til: ");
            double tal2 = double.Parse(Console.ReadLine());
            double kilometer = (tal1 * tal2) / 100000;
            Console.WriteLine($"Målestoksforholdet svarer til {kilometer:f3} km ");
            Console.WriteLine();
            

            Console.WriteLine("Opgave 3.6");
            Console.WriteLine("Camping, find pris efter uge nummer:");
            double uge = double.Parse(Console.ReadLine());
            double eur = 7.52;

            if (uge == 1)
            {
                Console.WriteLine($"I uge {uge} koster det 5000 DKK og {5000/eur} EUR ");
            }
            else if (uge >= 2 && uge <= 6)
            {
                Console.WriteLine($"I uge {uge} koster det 4000 DKK og {4000 / eur} EUR ");
            }
            else if (uge == 7)
            {
                Console.WriteLine($"I uge {uge} koster det 5500 DKK og {5500 / eur} EUR ");
            }
            else if (uge >= 8 && uge <= 26)
            {
                Console.WriteLine($"I uge {uge} koster det 4300 DKK og {4300 / eur} EUR ");
            }
            else if (uge >= 27 && uge <= 36)
            {
                Console.WriteLine($"I uge {uge} koster det 6000 DKK og {6000 / eur} EUR ");
            }
            else if (uge >= 37 && uge <= 50)
            {
                Console.WriteLine($"I uge {uge} koster det 4300 DKK og {4300 / eur} EUR ");
            }
            else if (uge >= 51 && uge <= 53)
            {
                Console.WriteLine($"I uge {uge} koster det 5000 DKK og {5000 / eur} EUR ");
            }
            else
            {
                Console.WriteLine("Dette er ikke et ugenummer");
            }
            Console.WriteLine();
            */
            Console.WriteLine("Opgave 3.7");
            int star = rnd.Next(1, 7);
            int star1 = 2;
            string tekst = $"Du rullede {star}!";
            switch (star)
            {
                case 1:
                    Console.WriteLine(tekst);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t *");
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine(tekst);
                    Console.WriteLine("*");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t \t *");
                    break;
                case 3:
                    Console.WriteLine(tekst);
                    Console.WriteLine("*");
                    Console.WriteLine();
                    Console.WriteLine("\t *");
                    Console.WriteLine();
                    Console.WriteLine("\t \t *");
                    break;
                case 4:
                    Console.WriteLine(tekst);
                    Console.WriteLine("*\t \t *");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("*\t \t *");
                    break;
                case 5:
                    Console.WriteLine(tekst);
                    Console.WriteLine("*\t \t *");
                    Console.WriteLine();
                    Console.WriteLine("\t *");
                    Console.WriteLine();
                    Console.WriteLine("*\t \t *");
                    break;
                case 6:
                    Console.WriteLine(tekst);
                    Console.WriteLine("*\t \t *");
                    Console.WriteLine();
                    Console.WriteLine("*\t \t *");
                    Console.WriteLine();
                    Console.WriteLine("*\t \t *");
                    break;
            }








            Console.ReadLine();
        }


    }
}
