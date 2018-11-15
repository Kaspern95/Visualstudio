using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS2
{
    class Scissor
    {
        public string name;
        public string weakness;
        public string strength;
        public Scissor(string name, string weakness, string strength)
        {
            this.name = name;
            this.weakness = weakness;
            this.strength = strength;
        }
    }
}
