using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodecaffe
{
    class Game
    {
        Spiller spiller1;
        Spiller spiller2;
        AlleKarakterer alleKarakterer = new AlleKarakterer();
       
        public void StartSpil()
        {
            spiller1 = new Spiller();
            spiller2 = new Spiller();
            spiller1.VaelgKarakter(alleKarakterer);
            spiller2.VaelgKarakter(alleKarakterer);
        }
    }
}
