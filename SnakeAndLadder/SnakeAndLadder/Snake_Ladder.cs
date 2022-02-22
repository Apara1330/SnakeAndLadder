using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Snake_Ladder
    {
        int firstPlayerPosition = 0;
        int secondPlayerPosition = 0;
        int ranOption;
        const int Max_Position = 100;//last position in the game
        int diceValue;
        int playerOneDiceCount;
        int playerTwoDiceCount;

        Random random = new Random();//to get random values
        public void GameBegins()
        {
            while (firstPlayerPosition <= Max_Position && secondPlayerPosition <= Max_Position)//to check value in the range 0 to 100
            {
                int checkPlayer = random.Next(0, 2);
                if (checkPlayer == 0)
                {
                    diceValue = random.Next(1, 7);

                    if (firstPlayerPosition >= 0 && firstPlayerPosition < 100)
                    {
                        ranOption = random.Next(0, 3);

                        if (ranOption == 0)
                        {
                            Console.WriteLine("Not played");
                        }
                        else if (ranOption == 1)
                        {
                            if (firstPlayerPosition + diceValue <= 100)
                            {
                                firstPlayerPosition = firstPlayerPosition + diceValue;
                                playerOneDiceCount++;
                                Console.WriteLine("Your chance again, play");
                                ranOption = random.Next(0, 3);

                                if (ranOption == 0)
                                {
                                    Console.WriteLine("Not played");
                                }
                                else if (ranOption == 1)
                                {
                                    if (firstPlayerPosition + diceValue <= 100)
                                    {
                                        firstPlayerPosition = firstPlayerPosition + diceValue;
                                        playerOneDiceCount++;
                                        Console.WriteLine("Ladder");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Still at same position");
                                    }
                                }
                                else if (ranOption == 2)
                                {
                                    if (firstPlayerPosition - diceValue <= 0)
                                    {
                                        firstPlayerPosition = 0;
                                        playerOneDiceCount++;
                                    }
                                    else
                                    {
                                        firstPlayerPosition = firstPlayerPosition - diceValue;
                                        playerOneDiceCount++;
                                        Console.WriteLine("Snake");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Still at same position");
                            }
                        }
                        else if (ranOption == 2)
                        {
                            if (firstPlayerPosition - diceValue <= 0)

                            {
                                firstPlayerPosition = 0;
                                playerOneDiceCount++;
                            }
                            else
                            {
                                firstPlayerPosition = firstPlayerPosition - diceValue;
                                playerOneDiceCount++;
                                Console.WriteLine("Snake");
                            }
                        }
                        Console.WriteLine(firstPlayerPosition);
                        Console.WriteLine(playerOneDiceCount);
                    }
                }


                else if (checkPlayer == 1)
                {
                    diceValue = random.Next(1, 7);
                    if (secondPlayerPosition >= 0 && secondPlayerPosition < 100)
                    {
                        ranOption = random.Next(0, 3);

                        if (ranOption == 0)
                        {
                            Console.WriteLine("Not played");
                        }

                        else if (ranOption == 1)
                        {
                            if (secondPlayerPosition + diceValue <= 100)
                            {
                                secondPlayerPosition = secondPlayerPosition + diceValue;
                                playerTwoDiceCount++;
                                Console.WriteLine("Your chance again, play");
                                ranOption = random.Next(0, 3);

                                if (ranOption == 0)
                                {
                                    Console.WriteLine("Not played");
                                }

                                else if (ranOption == 1)
                                {
                                    if (secondPlayerPosition + diceValue <= 100)
                                    {
                                        secondPlayerPosition = secondPlayerPosition + diceValue;
                                        playerTwoDiceCount++;
                                        Console.WriteLine("Ladder");

                                    }

                                    else
                                    {
                                        Console.WriteLine(" Still at same position");
                                    }
                                }

                                else if (ranOption == 2)
                                {
                                    if (secondPlayerPosition - diceValue <= 0)
                                    {
                                        secondPlayerPosition = 0;
                                        playerTwoDiceCount++;
                                    }
                                    else
                                    {
                                        secondPlayerPosition -= diceValue;
                                        playerTwoDiceCount++;
                                        Console.WriteLine("Snake");
                                    }
                                }

                            }

                            else
                            {
                                Console.WriteLine(" Still at same position");
                            }
                        }

                        else if (ranOption == 2)
                        {
                            if (secondPlayerPosition - diceValue <= 0)
                            {
                                secondPlayerPosition = 0;
                                playerTwoDiceCount++;
                            }
                            else
                            {
                                secondPlayerPosition -= diceValue;
                                playerTwoDiceCount++;
                                Console.WriteLine("Snake");
                            }
                        }
                        Console.WriteLine(secondPlayerPosition);
                        Console.WriteLine(playerTwoDiceCount);
                    }
                }



            }
        }
    }
}


