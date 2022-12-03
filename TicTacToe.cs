using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGames
{
    internal class TicTacToe
    {
        bool isNavigation;
        string[] arr = new string[9];
        string player1Token, player2Token;

        public TicTacToe()
        {
            isNavigation = true;
            this.player1Token = "X";
            this.player2Token = "O";

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = "-";
            }
        }

        public void Game()
        {
            GameLoop();
        }

        public void GameLoop()
        {
            arr[4] = "X";
            ConsoleKeyInfo keyInputInfo;

            while (isNavigation)
            {
                Console.WriteLine("___________________" +
                           "\n|     |     |     |" +
                           "\n|  " + arr[0] + "  |  " + arr[1] + "  |  " + arr[2] + "  |" +
                           "\n|_____|_____|_____|" +
                           "\n|     |     |     |" +
                           "\n|  " + arr[3] + "  |  " + arr[4] + "  |  " + arr[5] + "  |" +
                           "\n|_____|_____|_____|" +
                           "\n|     |     |     |" +
                           "\n|  " + arr[6] + "  |  " + arr[7] + "  |  " + arr[8] + "  |" +
                           "\n|_____|_____|_____|");

                keyInputInfo = Console.ReadKey();

                if (keyInputInfo.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    
                    // need if statements that make sure movement on array is done the right way

                    // scripted movement, not actually proper
                    arr[4] = "-";
                    arr[1] = "X";
                }

                if (keyInputInfo.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    Console.WriteLine("DOWN");
                }

                if (keyInputInfo.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    Console.WriteLine("RIGHT");
                }

                if (keyInputInfo.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    Console.WriteLine("LEFT");
                }
            }
        }
    }
}