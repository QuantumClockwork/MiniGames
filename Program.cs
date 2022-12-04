namespace MiniGames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" █████  ██████   ██████  █████  ██████  ███████                        " +
                            "\n██   ██ ██   ██ ██      ██   ██ ██   ██ ██                             " +
                            "\n███████ ██████  ██      ███████ ██   ██ █████                          " +
                            "\n██   ██ ██   ██ ██      ██   ██ ██   ██ ██                             " +
                            "\n██   ██ ██   ██  ██████ ██   ██ ██████  ███████");
            Console.ReadLine();

            TicTacToe ticTacToeGame = new TicTacToe();
            ticTacToeGame.GameLoop();
            Console.ReadLine();
        }
    }
}