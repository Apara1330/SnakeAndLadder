using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Snake_Ladder
    {
        int FirstPlayerPosition;

        Random random = new Random();

        public void GameBegins()
        {
            FirstPlayerPosition = 0;//1st player starting position zero
            int DiceValue = random.Next(1,7);
        }
    }
}
