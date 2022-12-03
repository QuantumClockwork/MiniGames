namespace MiniGames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToe ticTacToeGame = new TicTacToe();
            ticTacToeGame.Game();
            Console.ReadLine();
        }
    }
}