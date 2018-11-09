using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodecaffe
{
    public class Karakter
    {
        public string navn;
        public double liv;
        public Vaaben mitVaaben;
        public Karakter(string navn, double liv, Vaaben mitVaaben)
        {
            this.navn = navn;
            this.liv = liv;
            this.mitVaaben = mitVaaben;
        }
        public void Attack()
        {

        }
    }
}
