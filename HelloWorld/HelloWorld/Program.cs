using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    
    {
        static void Main(string[] args)
        {
            /*
            string beerCase = "masser af øl";
            
            Console.WriteLine(beerCase);
            Console.WriteLine("Hello World" + ", " + beerCase);

            string string1 = "Hello";
            string string2 = "World";
            string space = " ";
            Console.WriteLine(string1 + space + string2);
            */
            string world = "Hello World";
            Console.WriteLine("Opgave 1.1");
            Console.WriteLine(world + Environment.NewLine);

            string danish = "Hej Verden";
            string german = "Hallo Welt";
            string spanish = "Hola Mundo";
            string french = "Bonjour Monde";
            Console.WriteLine("Opgave 1.2");
            Console.WriteLine(world + Environment.NewLine +
            danish + Environment.NewLine +
            german + Environment.NewLine +
            spanish + Environment.NewLine +
            french + Environment.NewLine);
            

            Console.WriteLine("Opgave 1.3");
            string fornavn = "Mikkel";
            string efternavn = "Johansen";
            string tlf = "12345678";

            Console.WriteLine(world + " - " 
                + danish + " - " 
                + german + " - " 
                + spanish + " - " 
                + french + " " 
                + fornavn + " " 
                + efternavn 
                + "(" + "Mobil:" + tlf + ")" + Environment.NewLine);

            string navn = "Mikkel";
            string eNavn = "Johansen";
            Console.WriteLine("Mit fornavn er {0} og mit efternavn er {1}",navn,eNavn + Environment.NewLine);

            Console.WriteLine("Opgave 1.3 med placeholders");
            Console.WriteLine("{0} - {1} - {2} - {3} - {4} {5} {6}(Mobil:{7})",world,danish,german,spanish,french,fornavn,efternavn,tlf);




        }
    }
}
