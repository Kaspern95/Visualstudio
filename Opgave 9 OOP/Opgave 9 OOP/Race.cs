using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_9_OOP
{
    class Race
    {
        public Race(string name, int hp, int number, string strength, string weakness)
        {
            this.name = name;
            this.hp = hp;
            this.number = number;
            this.strength = strength;
            this.weakness = weakness;
        }
        public string name;
        public int hp;
        public int number;
        public string strength;
        public string weakness;
    }
}
