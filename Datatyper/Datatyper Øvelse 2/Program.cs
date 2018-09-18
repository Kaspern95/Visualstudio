using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatyper_Øvelse_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region opgave 2-2.9
            
            Console.WriteLine("Opgave 2.0");
            string linje1 = "Mit \"navn\" er 'Sten' \n" +
                "\\\\ \t didde-liddle-lidde-lum \t \\\\ \n" +
                "med det \"ekstra\" ben \n" +
                " \\\\ \t didde-liddle-lidde-lum \t \\\\ \n" +
                "Hvorhen jeg går i regn of slud, der peger folk mig altid ud.";
            string linje2 = "\\\\ \t didde-liddle-lidde-lum \t \\\\";
                

            Console.WriteLine(linje1);
            Console.WriteLine();



            Console.WriteLine("Opgave 2.1");
            int tal1 = 5;
            int tal2 = 10;
            int tal3 = 20;

            Console.WriteLine("Tal 1: {0} \n" +
                "Tal 2: {1} \n" +
                "Tal 3: {2} \n" +
                "------------------------------- \n" +
                "Resultat: {3} \n" +
                "===================", tal2,tal3,tal1,(tal1+tal2+tal3));
            Console.WriteLine();



            Console.WriteLine("Opgave 2.2");
            double kommaTal1 = 10.0;
            double kommaTal2 = 1.7;
            double kommaTal3 = 1.51;

            Console.WriteLine("Decimaltal 1: {0} \n" +
                "Decimaltal 2: {1} \n" +
                "Decimaltal 3: {2} \n" +
                "--------------------------------------- \n" +
                "Resultat: {0} + {1} + {2} = {3} \n" +
                "---------------------------------------", 
                kommaTal1,kommaTal2,kommaTal3,(kommaTal3+kommaTal2+kommaTal1));
            Console.WriteLine();



            Console.WriteLine("Opgave 2.3");
            double beløb1 = 10.75;
            double beløb2 = 10;
            double beløb3 = 1;
            double beløb4 = 1.25;
            double beløb5 = 5;
            double resultat = beløb1 + beløb2 + beløb3 + beløb4 + beløb5;

            Console.WriteLine("Beløb1: {0} \n" +
                "Beløb1: {1} \n" +
                "Beløb1: {2} \n" +
                "Beløb1: {3} \n" +
                "Beløb1: {4} \n" +
                "Total: {5} \n" +
                "Moms: {6} \n" +
                "Total inkl. moms: {7}",
                beløb1,beløb2,beløb3,beløb4,beløb5,resultat,(resultat*0.25),(resultat+(resultat * 0.25)));
            Console.WriteLine();


            
            Console.WriteLine("Opgave 2.4");
            string b1 = Console.ReadLine();
            beløb1 = double.Parse(b1);
            string b2 = Console.ReadLine();
            beløb2 = double.Parse(b2);
            string b3 = Console.ReadLine();
            beløb3 = double.Parse(b3);
            string b4 = Console.ReadLine();
            beløb4 = double.Parse(b4);
            string b5 = Console.ReadLine();
            beløb5 = double.Parse(b5);

            resultat = beløb1 + beløb2 + beløb3 + beløb4 + beløb5;
            Console.WriteLine("Beløb1: {0} \n" +
                "Beløb1: {1} \n" +
                "Beløb1: {2} \n" +
                "Beløb1: {3} \n" +
                "Beløb1: {4} \n" +
                "Total: {5} \n" +
                "Moms: {6} \n" +
                "Total inkl. moms: {7}",
                beløb1, beløb2, beløb3, beløb4, beløb5, resultat, (resultat * 0.25), (resultat + (resultat * 0.25)));
            Console.WriteLine();

            

            Console.WriteLine("Opgave 2.5");
            int opg = default;
            
            Console.WriteLine(opg);
            Console.WriteLine(opg + 1);
            Console.WriteLine(opg + 2);
            Console.WriteLine(opg * 10);
            Console.WriteLine(opg + 1);
            Console.WriteLine(opg / 5);
            Console.WriteLine(opg - 6);
            Console.WriteLine();

            Console.WriteLine("Opgave 2.6");

            double opg1 = default;

            Console.WriteLine(opg1);
            Console.WriteLine(opg1 + 1);
            Console.WriteLine(opg1 + 2);
            Console.WriteLine(opg1 * 10);
            Console.WriteLine(opg1 + 1);
            Console.WriteLine(opg1 / 5);
            Console.WriteLine(opg1 - 6);
            Console.WriteLine();

            Console.WriteLine("Opgave 2.7");
            double chiron = 30_000_000;
            double stk = 1000;
            Console.WriteLine("Hvis {0} Chiron biler sælges {1} stykket, er {2:c} indtjent",stk,chiron,(stk*chiron));
            Console.WriteLine();


            Console.WriteLine("Opgave 2.8");
            Console.WriteLine("indtast celcius temperatur");
            string celsius = Console.ReadLine();
            double cels = double.Parse(celsius);
            Console.WriteLine("Hvis temperaturen er {0} Celsius er den {1} fahrenheit",cels,((cels*1.8)+32));

            Console.WriteLine("indtast fahrenheit temperatur");
            string fahrenheit = Console.ReadLine();
            double fahren = double.Parse(fahrenheit);
            Console.WriteLine("Hvis temperaturen er {0} Celsius er den {1} fahrenheit",fahren,((fahren - 32)/1.8));
            Console.WriteLine();
            
            Console.WriteLine("Opgave 2.9");
            Console.WriteLine("Indtast din højde");
            string hd = Console.ReadLine();
            double højde = double.Parse(hd);
            Console.WriteLine("Indtast din vægt");
            string vg = Console.ReadLine();
            double vægt = double.Parse(vg);
            double højd = Math.Pow(højde, 2);
            double bmi = vægt/højd;
            
            Console.WriteLine("Du er {0} cm høj og vejer {1} kg, din BMI er {2}",højde,vægt,(vægt/(højde*2)));
            Console.WriteLine($"Du er {højde} cm høj og vejer {vægt} kg, din BMI er {bmi}");

            Console.WriteLine();
            #endregion
            

            Console.ReadLine();
        }
    }
}
