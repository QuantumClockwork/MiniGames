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
        string[] arrBoard = new string[9];
        string player1Token, emptyCell = "-";
        int destinationCell = 4, startCell = 4;

        public TicTacToe()
        {
            isNavigation = true;
            player1Token = "X";

            for (int i = 0; i < arrBoard.Length; i++)
            {
                arrBoard[i] = "-";
            }
            arrBoard[startCell] = player1Token;
        }

        public void GameLoop()
        {
            //arr[navigation] = player1Token;
            ConsoleKeyInfo keyInputInfo;

            while (isNavigation)
            {
                Console.WriteLine("MOVE WITH ARROW KEYS\n___________________" +
                    "\n|     |     |     |" +
                    "\n|  " + arrBoard[0] + "  |  " + arrBoard[1] + "  |  " + arrBoard[2] + "  |" +
                    "\n|_____|_____|_____|" +
                    "\n|     |     |     |" +
                    "\n|  " + arrBoard[3] + "  |  " + arrBoard[4] + "  |  " + arrBoard[5] + "  |" +
                    "\n|_____|_____|_____|" +
                    "\n|     |     |     |" +
                    "\n|  " + arrBoard[6] + "  |  " + arrBoard[7] + "  |  " + arrBoard[8] + "  |" +
                    "\n|_____|_____|_____|");

                keyInputInfo = Console.ReadKey();

                if (keyInputInfo.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    destinationCell = MoveCursor(ConsoleKey.UpArrow, destinationCell);
                }
                else if (keyInputInfo.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    destinationCell = MoveCursor(ConsoleKey.DownArrow, destinationCell);
                }
                else if (keyInputInfo.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    destinationCell = MoveCursor(ConsoleKey.RightArrow, destinationCell);
                }
                else if (keyInputInfo.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    destinationCell = MoveCursor(ConsoleKey.LeftArrow, destinationCell);
                }
            }
        }
        public int MoveCursor(ConsoleKey keyPressed, int cell)
        {
            if (keyPressed == ConsoleKey.UpArrow)
            {
                if (cell != 0 && cell != 1 && cell != 2)
                {
                    arrBoard[cell] = emptyCell;
                    cell -= 3;
                    arrBoard[cell] = player1Token;
                }
            }
            else if (keyPressed == ConsoleKey.DownArrow)
            {
                if (cell != 6 && cell != 7 && cell != 8)
                {
                    arrBoard[cell] = emptyCell;
                    cell += 3;
                    arrBoard[cell] = player1Token;
                }
            }
            else if (keyPressed == ConsoleKey.RightArrow)
            {
                if (cell != 8)
                {
                    arrBoard[cell] = emptyCell;
                    cell += 1;
                    arrBoard[cell] = player1Token;
                }
            }
            else if (keyPressed == ConsoleKey.LeftArrow)
            {
                if (cell != 0)
                {
                    arrBoard[cell] = emptyCell;
                    cell -= 1;
                    arrBoard[cell] = player1Token;
                }
            }
            return cell;
        }
    }
}