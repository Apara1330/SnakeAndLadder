using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Snake_Ladder
    {
        int ranOption;
        const int Max_Position = 100;//last position in the game
        int currPosition = 0;
        int diceValue;
        int DiceCount;

        Random random = new Random();//to get random values
        public void GameBegins()
        {
            while (currPosition <= Max_Position)//to  reach maximum position
            {
                diceValue = random.Next(1, 7);
                if (currPosition >= 0 && currPosition < 100)
                {
                    ranOption = random.Next(0, 3);

                    if (ranOption == 0)
                    {
                        Console.WriteLine("Not played");
                        DiceCount++;
                    }

                    else if (ranOption == 1)
                    {
                        if (currPosition + diceValue <= 100)
                        {
                            currPosition = currPosition + diceValue;
                            Console.WriteLine("Ladder");
                            DiceCount++;
                        }
                        else
                        {
                            Console.WriteLine(" Still at same position");
                        }
                    }
                    else if (ranOption == 2)
                        if (currPosition - diceValue <= 0)
                        {
                            currPosition = 0;
                            DiceCount++;
                        }
                        else
                        {
                            currPosition = currPosition - diceValue;
                            Console.WriteLine("Snake");
                            DiceCount++;
                        }
                }
                Console.WriteLine(currPosition);
                Console.WriteLine(DiceCount);
                Console.WriteLine();
            }
        }
    }
}

