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
                "Med det ekstra ben, didde lidde lidde lum .. " +
                "Hvorhen jeg går i regn og slud, der peger folk mig altid ud.";
            /*
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
                        string dyr = "ko gris hest flodhest mus rotte hund kat";
                        string[] destination = dyr.Split(' ');

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
                        */

            //Opgave7_3(stenSang);
            //Opgave7_3Alt(stenSang);
            //Opgave7_4();
            //Opgave7_5();
            //Opgave7_6();
            //Opgave7_7();
            Opgave7_8();
            Console.ReadLine();
        }

        private static void Opgave7_8()
        {
            string tal1 = "200 kr.";
            string tal2 = "50 kr.";
            string tal3 = "5 kr.";

            string res1 = AddMoney(tal1, tal2);
            string res2 = AddMoney(res1, tal3);
        }

        private static string AddMoney(string tal1, string tal2)
        {
            
            string amount1 = tal1.Substring(0, tal1.Length - 4);
            int tal1Kon = int.Parse(amount1);

            string amount2 = tal2.Substring(0, tal2.Length - 4);
            int tal2Kon = int.Parse(amount2);

            int res = tal1Kon + tal2Kon;
            string resString = res + " kr.";
            return resString;
        }

        private static void Opgave7_7()
        {
            string tekst = "Det er ritig let med stringmetoder, at rette ritig mange ens stavefejl.";
            Console.WriteLine(tekst);
            string input = Console.ReadLine();
            string result = tekst.Replace("ritig", input);
            Console.WriteLine(result);
        }

        private static void Opgave7_6()
        {
            Console.WriteLine("Indtast et tal eller bogstav");
            string stringNumber = Console.ReadLine();
            //int number;
            //bool result = int.TryParse(stringNumber, out number);
            //Console.WriteLine($"din indtastning er {result} datatypen på dit input er {number.GetType()}");
            
            bool erDetEtTal = talTester(stringNumber);

        }

        private static bool talTester(string testString)
        {
            bool result = true;
            char[] array = testString.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (!(array[i] >= 48 && array[i] <= 57))
                {
                    result = false;
                    break;
                }
                

            }
            return result;
        }

        private static void Opgave7_5()
        {
            string password = "KlauS";
            Console.WriteLine("Indtast password");
            string input = Console.ReadLine();
            string bigInput = input.ToUpper();
            string bigPassword = password.ToUpper();

            if (bigInput == bigPassword)
            {
                Console.WriteLine("success");
              
            }
            else
            {
                Console.WriteLine("fail");
                
            }
        }

        private static void Opgave7_4()
        {
            string input = Console.ReadLine();
            char[] array = input.ToCharArray();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i]);

            }
        }

        private static void Opgave7_3Alt(string sang)
        {
            string[] array;
            array = sang.Split(',', ' ');
            string input = Console.ReadLine();

            if (array.Contains(input))
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == input)
                    {
                        count++;

                    }
                }
                Console.WriteLine(count);

            }
            else
            {
                Console.WriteLine("Nope");
            }

            

        }

        private static void Opgave7_3(string sang)
        {
            string check = Console.ReadLine();
            int count = 0;
            int index = 0;

            while (true)
            {
                index = sang.IndexOf(check, index );
                if (index != -1)
                {
                    count++;
                    index++;
                }
                else
                {
                    break;
                }
                
            }
            Console.WriteLine(count);

        }
    }
}
