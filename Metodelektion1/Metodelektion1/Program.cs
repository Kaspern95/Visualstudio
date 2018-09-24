using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodelektion1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintMig();
            //Adresse();
            //Kontakt();
            //Trekant();
            Bog();
            int nr1 = 5;
            int nr2 = 10;
            
            int result = Add(nr1,nr2);

            CalculateTriangle(5, 2, 3);

            Console.ReadLine();
        }
        static void PrintMig()
        {
            Console.WriteLine("Datamatiker studerende");
            Console.WriteLine("Kasper Nielsen");
            Console.WriteLine("Kastanievænget 37");
            Console.WriteLine("7800 Skive");
            Console.WriteLine("60812003");
            Console.WriteLine("Kaspervman@gmail.com");
        }
        static void Adresse()
        {
            Console.WriteLine("Kastanievænget ");
            Console.WriteLine("7800");
            Console.WriteLine("Skive");
        }
        static void Kontakt()
        {
            Console.WriteLine("60812003");
            Console.WriteLine("Kaspervman@gmail.com");
        }
        static void Trekant()
        {
            Console.WriteLine("Indtast længden på 3 sider i en trekant:");
            double tal1 = double.Parse(Console.ReadLine());
            double tal2 = double.Parse(Console.ReadLine());
            double tal3 = double.Parse(Console.ReadLine());
            double resultat = tal1 + tal2 + tal3;
            double gennemsnit = resultat / 3;
            Console.WriteLine($"Side 1: {tal1}, Side 2: {tal2}, Side 3: {tal3}");
            Console.WriteLine($"Trekantens omkreds er {resultat}");
            Console.WriteLine($"Den gennemsnitlige længde på trekantens sider er {gennemsnit:f}");
        }
        static void Bog()
        {
            Console.WriteLine("Her kan du indtaste informationer vedrørende en bog.");
            Console.Write("Indtast bogens ISBN: ");
            double isbn = double.Parse(Console.ReadLine());
            Console.Write("Indtast bogens titel: ");
            string titel = Console.ReadLine();
            Console.Write("Indtast bogens forlag: ");
            string forlag = Console.ReadLine();
            Console.Write("Indtast bogens forfatter: ");
            string forfatter = Console.ReadLine();
            Console.Write("Indtast bogens udgivelsesår: ");
            double udg = double.Parse(Console.ReadLine());
            Console.Write("Indtast bogens pris: ");
            double pris = double.Parse(Console.ReadLine());
            Console.Write("Indtast bogens Bogens side antal: ");
            double sideAntal = double.Parse(Console.ReadLine());
            Console.Write($"Her er gennemsnits prisen per side: {pris/sideAntal:f1}kr. ");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Bogens ISBN: \t\t{isbn}");
            Console.WriteLine($"Bogens titel: \t\t{titel}");
            Console.WriteLine($"Bogens forlag: \t\t{forlag}");
            Console.WriteLine($"Bogens forfatter: \t{forfatter}");
            Console.WriteLine($"Bogens udgivelsesår: \t{udg}");
            Console.WriteLine($"Bogens pris: \t\t{pris:c}");
            Console.WriteLine($"Bogens sidetal: \t{sideAntal}");
            Console.WriteLine($"Bogens pris per side: \t{pris/sideAntal:f1} kr.");
        }

        static int Add(int tal1, int tal2)
        {
            int resultat;
            resultat = tal1 + tal2;
            return resultat;

        }

        static void CalculateTriangle(int side1, int side2, int side3)
        {
            int omkreds = side1 + side2 + side3;
            Console.WriteLine(omkreds);
        }
    }
}
