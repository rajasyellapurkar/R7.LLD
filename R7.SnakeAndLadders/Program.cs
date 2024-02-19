using R7.SnakeAndLadders.Commands;

namespace R7.SnakeAndLadders
{
    internal class Program
    {
        private static CommandRegistry _commandRegistry = null!;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladders game");
            RegisterAllCommand();
            PrintCommandHelp();
            Console.WriteLine(Environment.NewLine);
            do
            {
                Console.WriteLine("Enter command");
                Console.WriteLine();
                string? userInput = Console.ReadLine();
                if(!string.IsNullOrEmpty(userInput))
                {
                    _commandRegistry.Execute(userInput);
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            } while (true);
        }

        private static void PrintCommandHelp()
        {
            Console.WriteLine("RegisterUser username email password");
            Console.WriteLine("StartGame user1email user2email boardSize SnakesLadderManualOrAutomatic");
        }

        private static void RegisterAllCommand()
        {
            RegisterUserCommand registerUserCommand = new RegisterUserCommand();
            StartGameCommand startGameCommand = new StartGameCommand();

            _commandRegistry = new CommandRegistry();
            _commandRegistry.RegisterCommand(registerUserCommand);
            _commandRegistry.RegisterCommand(startGameCommand);
        }
    }
}
