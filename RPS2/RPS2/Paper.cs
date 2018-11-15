using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS2
{
    class Paper
    {
        public string name;
        public string weakness;
        public string strength;
        public Paper(string name, string weakness, string strength)
        {
            this.name = name;
            this.weakness = weakness;
            this.strength = strength;
        }
    }
}
