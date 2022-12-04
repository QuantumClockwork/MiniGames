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
        int navigation;

        public TicTacToe()
        {
            isNavigation = true;
            this.player1Token = "X";
            this.player2Token = "O";

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = "-";
            }
            arr[4] = player1Token;
            navigation = 4;
        }

        public void GameLoop()
        {
            //arr[navigation] = player1Token;
            ConsoleKeyInfo keyInputInfo;

            while (isNavigation)
            {
                Console.WriteLine("ARROW KEYS FOR MOVEMENT");
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
                    navigation = MoveCursor(ConsoleKey.UpArrow, navigation);
                }

                else if (keyInputInfo.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    navigation = MoveCursor(ConsoleKey.DownArrow, navigation);
                }

                else if (keyInputInfo.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    navigation = MoveCursor(ConsoleKey.RightArrow, navigation);
                }

                else if (keyInputInfo.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    navigation = MoveCursor(ConsoleKey.LeftArrow, navigation);
                }
            }
        }
        public int MoveCursor(ConsoleKey key, int nav)
        {
            if (key == ConsoleKey.UpArrow)
            {
                if (nav != 0 && nav != 1 && nav != 2)
                {
                    arr[nav] = "-";
                    nav = nav - 3;
                    arr[nav] = player1Token;
                }
            }

            else if (key == ConsoleKey.DownArrow)
            {
                if (nav != 6 && nav != 7 && nav != 8)
                {
                    arr[nav] = "-";
                    nav = nav + 3;
                    arr[nav] = player1Token;
                }
            }

            else if (key == ConsoleKey.RightArrow)
            {
                if (nav != 8)
                {
                    arr[nav] = "-";
                    nav = nav + 1;
                    arr[nav] = player1Token;
                }
            }

            else if (key == ConsoleKey.LeftArrow)
            {
                if (nav != 0)
                {
                    arr[nav] = "-";
                    nav = nav - 1;
                    arr[nav] = player1Token;
                }
                
            }
            return nav;
        }
    }
}