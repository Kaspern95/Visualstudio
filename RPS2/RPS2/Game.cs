using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS2
{
    class Game
    {
        Rock rock = new Rock("Rock", "Paper", "Scissor");
        Paper paper = new Paper("Paper", "Scissor", "Rock");
        Scissor scissor = new Scissor("Scissor", "Rock", "Paper");

        Rock pRock = new Rock("Rock", "Paper", "Scissor");
        Paper pPaper = new Paper("Paper", "Scissor", "Rock");
        Scissor pScissor = new Scissor("Scissor", "Rock", "Paper");

        Rock cRock = new Rock("Rock", "Paper", "Scissor");
        Paper cPaper = new Paper("Paper", "Scissor", "Rock");
        Scissor cScissor = new Scissor("Scissor", "Rock", "Paper");

        public void RockWin()
        {
            string win;
            if(pRock.name == cScissor.weakness)
            {
                win = $"{rock.name} beat {scissor.name}";
            }

        }
    }
}
