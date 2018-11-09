using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodecaffe
{
    class Spiller
    {
        public string navn;
        public Karakter minKarakter;

        public void VaelgKarakter(AlleKarakterer alle)
        {
            Console.WriteLine(navn + " vælg din karakter");
            Console.WriteLine("tryk 1 for at vælge " + alle.karakterer[0].navn);
            Console.WriteLine("tryk 2 for at vælge " + alle.karakterer[1].navn);
            int valg = int.Parse(Console.ReadLine());

            switch (valg)
            {
                case 1:
                    minKarakter = alle.karakterer[0];
                    break;
                case 2:
                    minKarakter = alle.karakterer[1];
                    break;
                default:
                    break;
            }
        }
    }
}
