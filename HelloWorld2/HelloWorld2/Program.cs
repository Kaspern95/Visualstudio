using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("hej, hvad hedder du?: ");
            string navn = Console.ReadLine();
            Console.WriteLine("Fedt navn " + navn + ", rart at møde dig");
            Console.ReadLine();*/

            /*
            Console.WriteLine("Opgave 1.3");
            Console.Write("Hvad er dit navn?:");
            string navn = Console.ReadLine();
            Console.WriteLine("Hej "+navn);
            
            Console.Write("hvad er dit efternavn?:");
            string efterNavn = Console.ReadLine();
            Console.WriteLine(efterNavn);

            Console.Write("Hvad er dit tlf nr?:");
            string tlf = Console.ReadLine();
            Console.WriteLine(tlf);
            */
            Console.WriteLine("opgave 1.5");

            Console.WriteLine("Lav et plusstykke");
            string t1 = Console.ReadLine();
            Console.Write("+");
            string t2 = Console.ReadLine();
          
            int tal1 = Convert.ToInt32(t1);
            int tal2 = Convert.ToInt32(t2);

            Console.WriteLine(tal1 + tal2);
            Console.WriteLine();
            /*
            Console.WriteLine((t1) + (t2) + (tal1 + tal2));
            Console.WriteLine("10 - 5 = " + (tal1 + tal2));
            Console.WriteLine("10 * 5 = " + (tal1 * tal2));
            Console.WriteLine("10 / 5 = " + (tal1 / tal2));
            */

            Console.WriteLine("opgave 1.6");

            int thisYear = DateTime.Now.Year;
            int retirement = 68;
            Console.WriteLine("What is your age?:");
            string age = Console.ReadLine();
            int age1 = Convert.ToInt32(age);
            
            Console.WriteLine("Your age is {0}, you can retire in the year {1}, in {2} years. ",age1,((retirement-age1)+thisYear),(retirement-age1));
            Console.ReadLine();

        }
    };
}
