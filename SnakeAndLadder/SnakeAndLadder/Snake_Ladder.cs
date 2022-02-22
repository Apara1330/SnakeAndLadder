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
        int Max_Position = 100;//last position in the game

        Random random = new Random();//to get random values
        public void GameBegins()
        {
            FirstPlayerPosition = 0; //First player starting at 0th position
            while (FirstPlayerPosition <= Max_Position)
            {
                
                int DiceValue = random.Next(1, 7);//Taking random value of Dice from 1-6

                ranOption = random.Next(0, 3);

                if (ranOption == 0)
                {
                    Console.WriteLine("Not played");
                    FirstPlayerPosition = FirstPlayerPosition+ FirstPlayerPosition;
                }
                else if (ranOption == 1)
                {
                    Console.WriteLine("Ladder");
                    FirstPlayerPosition = FirstPlayerPosition + DiceValue;

                    if (FirstPlayerPosition + DiceValue <= 100)
                    {
                        FirstPlayerPosition = FirstPlayerPosition + DiceValue;

                        Console.WriteLine("Ladder");

                    }

                    else
                    {
                        Console.WriteLine(" Still at same position");
                    }
                }
                else if (ranOption == 2)
                {
                    Console.WriteLine("Snake");
                    FirstPlayerPosition = FirstPlayerPosition - DiceValue;
                }
                else
                {
                    Console.WriteLine("Invalid move");
                }
            }
        }
        }
    }

