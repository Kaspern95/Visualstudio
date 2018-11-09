using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodecaffe
{
    public class AlleKarakterer
    {
        public List<Karakter> karakterer = new List<Karakter>();
        
        public void FyldKarakterer()
        {
            karakterer.Add(new Karakter("Kriger", 100, new Vaaben("Sværd", 10)));
            karakterer.Add(new Karakter("BueSkytte", 80, new Vaaben("Bue", 15)));

        }
    }
}
