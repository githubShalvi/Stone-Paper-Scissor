using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonePaperScissor
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string Playerinput, CPUinput;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {

                int scoreP = 0;
                int scoreC= 0;

                while (scoreP < 3 && scoreC < 3)
                {


                    Console.Write("Choose between STONE, PAPER and SCISSORS:    ");
                    Playerinput = Console.ReadLine();
                    Playerinput = Playerinput.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            CPUinput = "STONE";
                            Console.WriteLine("Computer chose STONE");
                            if (Playerinput == "STONE")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (Playerinput == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scoreP++;
                            }
                            else if (Playerinput == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreC++;
                            }
                            break;
                        case 2:
                            CPUinput = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (Playerinput == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (Playerinput == "STONE")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreC++;
                            }
                            else if (Playerinput == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scoreP++;
                            }
                            break;
                        case 3:
                            CPUinput = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (Playerinput == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (Playerinput == "STONE")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scoreP++;
                            }
                            else if (Playerinput == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreC++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scoreP, scoreC);

                }

                if (scoreP == 3)
                {
                    Console.WriteLine("Player WON!");
                }
                else if (scoreC== 3)
                {
                    Console.WriteLine("CPU WON!");
                }
                
                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                

            }
        }
    }
}
