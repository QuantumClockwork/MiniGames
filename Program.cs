namespace MiniGames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToe ticTacToeGame = new TicTacToe();
            ticTacToeGame.Game();
            Console.ReadLine();
            //reference kinda
            string gameBoard = "   a     b     c" +
                           "\n      |     |     " +
                           "\n1  -  |  -  |  -  " +
                           "\n _____|_____|_____" +
                           "\n      |     |     " +
                           "\n2  -  |  -  |  -  " +
                           "\n _____|_____|_____" +
                           "\n      |     |     " +
                           "\n3  -  |  -  |  -  " +
                           "\n      |     |     ";
        }
    }
}