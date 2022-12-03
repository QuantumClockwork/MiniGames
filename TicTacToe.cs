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
        string[,] gameBoardArr = new string[3, 3];
        string player1Token, player2Token, gameBoard;

        public TicTacToe()
        {
            /// what does this object need?
            /// it needs a board that it draws
            /// it need to have X and O symbols (tokens)
            /// it needs methods that alter the board after input

            isNavigation = true;
            this.player1Token = "X";
            this.player2Token = "O";

            for (int i = 0; i < gameBoardArr.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoardArr.GetLength(1); j++)
                {
                    gameBoardArr[i, j] = "-";
                }
            }
        }

        public void Game()
        {
            GameLoop();
        }

        public void GameLoop()
        {
            // array visual
            // 0 1 2
            // 3 4 5
            // 6 7 8

            ConsoleKeyInfo keyInputInfo;

            while (isNavigation)
            {
                keyInputInfo = Console.ReadKey();

                if (keyInputInfo.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    Console.WriteLine("UP");
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
