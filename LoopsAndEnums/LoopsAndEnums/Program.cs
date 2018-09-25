using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndEnums
{
    class Program
    {
        enum UgeDage
        {
            Mandag,
            Tirsdag,
            Onsdag,
            Torsdag,
            Fredag,
            Lørdag,
            Søndag
                
        };
        static void Main(string[] args)
        {
            #region enums
            UgeDage idag = UgeDage.Onsdag; 
            
            if (idag >= UgeDage.Tirsdag && idag < UgeDage.Fredag)
            {

            }
            #endregion


            //SjovMedWhile();
            //SjovMedDoWhile();
            //SjovMedForEach();
            SjovMedFor();
            

            Console.ReadLine();
        }

        private static void SjovMedFor()
        {
            

            string[] navne = new string[1000];

            for (int i = 0; i < navne.Length; i++)
            {
                navne[i] = "hej " + i;
                Console.WriteLine(navne[i]);
            }
            
        }

        private static void SjovMedForEach()
        {
            string[] navne = new string[5] { "per", "henning", "louise", "gunner", "torben" };
            foreach  (string navn in navne)
            {
                Console.WriteLine(navn);
                
            }
        }

        private static void SjovMedDoWhile()
        {
            string password = "1234";
            bool erDetSandt = false;
            int wrongPW = 0;

            do
            {
                Console.WriteLine("Indtast password: ");
                string input = Console.ReadLine();
                if (wrongPW >= 5)
                {
                    Console.WriteLine("Du har prøvet for mange gange.");
                    erDetSandt = true;
                }
                if (input == password)
                {
                    Console.WriteLine("yee boi");
                    erDetSandt = true;
                }
                else
                {
                    Console.WriteLine("nope");
                    wrongPW++;
                }

            } while (!erDetSandt);
            
        }

        private static void SjovMedWhile()
        {
            string password = "1234";
            bool erDetRigtig = false;
            int wrongPw = 0;
            while (erDetRigtig == false && wrongPw < 5)
            {
                Console.Write("Skriv dit password: ");
                string input = Console.ReadLine();
                if (input == password)
                {
                    Console.WriteLine("Koden er rigtig");
                    erDetRigtig = true;
                }
                else
                {
                    Console.WriteLine("NOPE");
                    wrongPw++;
                    
                }
                if (wrongPw >= 5)
                {
                    Console.WriteLine("Desværre");
                }
            }
        }
    }
}
