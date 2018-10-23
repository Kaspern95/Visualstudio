using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_9_OOP_p2
{
    class Program
    {
        static void Main(string[] args)
        {
           Race Elf = new Race("Elf", 10, 1, "Nature", "Fire");
            Race Orc = new Race("Orc", 10, 2, "Physical", "Nature");
            Race Dwarf = new Race("Dwarf", 10, 3, "Fire", "Water");
            Race Naga = new Race("Naga", 10, 4, "Water", "Physical");
            Race Player1 = new Race("", 0, 0, "", "");

            int p1 = 1;
            int p2 = 3;

            if (p1 == Elf.number)
            {
                Player1 = Elf;
            }
            else if (p1 == Orc.number)
            {
                int p1Hp = Orc.hp;
                string p1Weakness = Orc.weakness;
            }
            else if (p1 == Dwarf.number)
            {
                int p1Hp = Dwarf.hp;
                string p1Weakness = Dwarf.weakness;
            }
            else if (p1 == Naga.number)
            {
                int p1Hp = Naga.hp;
                string p1Weakness = Naga.weakness;
            }
            Console.WriteLine(Player1.hp);
            //Console.WriteLine(Player1.number);
            #region p2 charsheet
            if (p2 == Elf.number)
            {
                int p2Hp = Elf.hp;
                string p2Weakness = Elf.weakness;
            }
            else if (p2 == Orc.number)
            {
                int p2Hp = Orc.hp;
                string p2Weakness = Orc.weakness;
            }
            else if (p2 == Dwarf.number)
            {
                int p2Hp = Dwarf.hp;
                string p2Weakness = Dwarf.weakness;
            }
            else if (p2 == Naga.number)
            {
                int p2Hp = Naga.hp;
                string p2Weakness = Naga.weakness;
            }
            #endregion
        }
    }
}
