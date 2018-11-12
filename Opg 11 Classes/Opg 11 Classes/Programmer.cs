using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_11_Classes
{
    class Programmer : Worker
    {
        public string language;

        public override string ToString()
        {
            return language;
        }
    }
}
