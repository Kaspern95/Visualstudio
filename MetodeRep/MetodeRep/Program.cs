using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodeRep
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            double hs = HovedStol();
            double rf = Rentefod() / 100;
            int tm = Terminer();
            double yd = Ydelse(hs, rf, tm);
            Resultat(hs, rf, tm, yd);

            Console.WriteLine();
            */
            //Add();
            double result = Add(5.5, 8);
            Console.WriteLine("Angiv første tal");
            double tal1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Angiv matematisk operator");
            char op1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Angiv andet tal");
            double tal2 = double.Parse(Console.ReadLine());

            double res = Calculate(tal1, tal2, op1);

            Console.Clear();
            Console.WriteLine(res);
            Console.ReadLine();
        }
        static double HovedStol()
        {
            Console.WriteLine("Indtast lånets Hovedstol:");
            string hovedStol = Console.ReadLine();
            return double.Parse(hovedStol);
        }
        static double Rentefod()
        {
            Console.WriteLine("Indtast lånets Rentefod: ");
            double rentefod = double.Parse(Console.ReadLine());
            return rentefod;
        }
        static int Terminer()
        {
            Console.WriteLine("Indtast lånets antal terminer: ");
            int terminer = int.Parse(Console.ReadLine());
            return terminer;
        }
        static double Ydelse(double hs, double rf, int tm)
        {
            return hs * rf / (1-Math.Pow(1 + rf, - tm));
        }
        /// <summary>
        /// Denne metode printer et Resultat ark over et lån
        /// </summary>
        /// <param name="hs">hovedstole</param>
        /// <param name="rf">renten</param>
        /// <param name="tm">terminer</param>
        /// <param name="yd">ydelsen per termin</param>
        static void Resultat(double hs, double rf, int tm, double yd)
        {
            Console.WriteLine($"Hovedstol er: \t{hs}\n" +
                $"Rentefod er: \t{rf * 100}%\n" +
                $"Terminer er: \t{tm}\n" +
                $"Ydelsen er: \t{yd:c}");
            
        }
        static double Add(double x, double y)
        {
            return x + y;
        }
        static void Add()
        {
            Console.WriteLine("skriv første tal: ");
            double tal1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Skriv andet tal: ");
            double tal2 = double.Parse(Console.ReadLine());

            double result = tal1 + tal2;
            Console.WriteLine("Resultatet er {0}", result);
        }
        static double Sub(double x, double y)
        {
            return x - y;
        }
        static double Multi(double x, double y)
        {
            return x * y;
        }
        static double Div(double x, double y)
        {
            return x / y;
        }
        static double Calculate(double x, double y, char o)
        {
            double res;
            switch (o)
            {
                case '+':
                    res = Add(x, y);
                    break;
                case '-':
                    res = Sub(x, y);
                    break;
                case '*':
                case 'x':
                case 'X':
                    res = Multi(x, y);
                    break;
                case '/':
                    res = Div(x, y);
                    break;
                default:
                    res = -1;
                    Console.WriteLine("Anvend en matematisk operator.");
                    break;
            }
            return res;

        }
    }

}
