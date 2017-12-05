using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    class Program
    {   public static string[,] spots = new string[3,3];
        public static bool turn = true;
        public static int count = 0;
        static public void Main()
        {
            
            
            for(int i=0; i< 3; i++)
            {
                for(int o =0; o<3; o++)
                {
                    spots[i, o] = "| |"; 
                }
            }
            changevalues();
        }
        public static void changevalues()
        {
            Console.Clear();
            string player = "";
            int row = 0, colume = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int o = 0; o < 3; o++)
                {
                    Console.Write(spots[i, o]);
                }
                Console.Write("\n");
            }



            if (count == 9)
            {
                game_over();
            }

            else
            {
                if (turn)
                {
                    player = "player 1";
                }
                else if (!turn)
                {
                    player = "player 2";
                }
                try
                {
                    Console.WriteLine(player + " what row do you want to make your play in?");
                    row = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception unhandable)
                {
                    Console.Write("nedds to be a number that coralats with the row");
                    Console.ReadLine();
                    changevalues();
                }
                try
                {
                    Console.WriteLine("what colume would you like to make your move in");
                    colume = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception unhandable)
                {
                    Console.Write("nedds to be a number that coralats with the Colume");
                    Console.ReadLine();
                    changevalues();
                }

                if ((row >= 1) && (row <= 3) && (colume >= 1) && (colume <= 3))
                    {
                    if (spots[row - 1, colume - 1] == "| |")
                    {
                        if (turn)
                        {
                            spots[row - 1, colume - 1] = "|X|";
                        }
                        else if (!turn)
                        {
                            spots[row - 1, colume - 1] = "|O|";
                        }
                        turn = !turn;
                        count++;
                    }
                    else
                    {
                        Console.Write("you cant mover there");
                        Console.ReadLine();
                        changevalues();
                    }

                    check_for_winner();
                }
                else
                {
                    Console.WriteLine("you need to pick a row and colume");
                    Console.ReadLine();
                    changevalues();
                }
            }
        }
        public static void check_for_winner()
        {
            //horazontal check
            if ((spots[0, 0] == spots[0, 1]) && (spots[0, 1] == spots[0, 2]) && (spots[0, 0] != "| |"))
            {
                game_over();
            }
            else if ((spots[1, 0] == spots[1, 1]) && (spots[1, 1] == spots[1, 2]) && (spots[1, 0] != "| |"))
            {
                game_over();
            }
            else if ((spots[2, 0] == spots[2, 1]) && (spots[2, 1] == spots[2, 2]) && (spots[2, 0] != "| |"))
            {
                game_over();
            }
            //vertical check
            else if ((spots[0, 0] == spots[1, 0]) && (spots[1, 0] == spots[2, 0]) && (spots[0, 0] != "| |"))
            {
                game_over();
            }
            else if ((spots[0, 1] == spots[1, 1]) && (spots[1, 1] == spots[2, 1]) && (spots[1, 1] != "| |"))
            {
                game_over();
            }
            else if ((spots[0, 2] == spots[1, 2]) && (spots[1, 2] == spots[2, 2]) && (spots[1, 2] != "| |"))
            {
                game_over();
            }
            //other check
            else if ((spots[0, 0] == spots[1, 1]) && (spots[1, 1] == spots[2, 2]) && (spots[1, 1] != "| |"))
            {
                game_over();
            }
            else if ((spots[0, 2] == spots[1, 1]) && (spots[1, 1] == spots[2, 0]) && (spots[1,1] != "| |"))
            {
                game_over();
            }
            else
            {
                changevalues();
            }
        }
        public static void game_over()
        {
            string choose = "";
            for (int i = 0; i < 3; i++)
            {
                for (int o = 0; o < 3; o++)
                {
                    Console.Write(spots[i, o]);
                }
                Console.Write("\n");
            }
            do
            {
                Console.WriteLine("do you want continue (y/n) ");
                choose = Console.ReadLine();
            } while (choose.ToLower() != "n" && choose.ToLower() != "y");
            if (choose == "y")
            {
                Main();
            }
            else if(choose == "n")
            {
                Console.Read();
            }
        }

    } 
}
