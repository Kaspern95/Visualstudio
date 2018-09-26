using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string stenSang = "Mit navn er Steen, didde lidde lidde lum " +
                "Med det ekstra ben, didde lidde lidde lum.. " +
                "Hvorhen jeg går i regn og slud, der peger folk mig altid ud.";

            Console.WriteLine("opgave 7.1");
            Console.WriteLine("Skriv et ord i sangen \"mit navn er steen\"");
            string check = Console.ReadLine();
            bool strcheck = stenSang.Contains(check);

            if (strcheck == true)
            {
                Console.WriteLine($"{check} findes i strengen");
            }
            else
            {
                Console.WriteLine("{0} findes desværre ikke i sangen",0);
            }
            Console.WriteLine();

            Console.WriteLine("opgave 7.2");
            string dyr = "ko, gris, hest, flodhest, mus, rotte, hund, kat";
            string[] destination = dyr.Split(", ".ToCharArray());
            
            foreach (string navne in destination)
            {
                Console.WriteLine(navne);
            }
            Console.WriteLine();
            Console.WriteLine("Opgave 7.3");

            //string stenSangCheck = Console.ReadLine();
            int count = 0;
            int i = 0;
            while((i = stenSang.IndexOf(check, i)) != -1)
            {
                i += check.Length;
                count++;
            }
            Console.WriteLine($"{check} opstod {count} gange");
            Console.WriteLine();

            Console.WriteLine("Opgave 7.4");

            string reverse = Console.ReadLine();
            string reversedString = "";
            for (int i2 = reverse.Length - 1; i2 >= 0; i2--)
            {
                reversedString += reverse[i2];
            }
            Console.WriteLine(reversedString);



            Console.ReadLine();
        }
    }
}
