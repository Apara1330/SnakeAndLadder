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
        int ranOption;

        Random random = new Random();
        public void game()
        {
            FirstPlayerPosition = 0; //First player starting at 0th position

            int DiceValue = random.Next(1, 7);//Taking random value of Dice from 1-6
            ranOption = random.Next(0, 3);

            if (ranOption == 0)
            {
                Console.WriteLine("no play");
                FirstPlayerPosition += FirstPlayerPosition;
            }
            else if (ranOption == 1)
            {
                Console.WriteLine("Ladder");
                FirstPlayerPosition = FirstPlayerPosition + DiceValue;
            }
            else
            {
                Console.WriteLine("Snake");
                FirstPlayerPosition = FirstPlayerPosition + DiceValue;
            }
        }
    }
}
