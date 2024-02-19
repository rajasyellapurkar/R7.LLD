using R7.SnakeAndLadders.Commands.Interface;
using R7.SnakeAndLadders.Controllers;

namespace R7.SnakeAndLadders.Commands
{
    internal class RegisterUserCommand : ICommand
    {
        UserController userController = new UserController();
        private string[] commands = new string[0];
        public void Execute()
        {
            string userName = commands[1];
            string email = commands[2];
            string password = commands[3];
            userController.RegisterUser(userName, email, password);
        }

        public bool Matches(string command)
        {
            commands = command.Split(" ");
            bool lengthCondition = commands.Length == 4;
            bool stringMatchCondition = commands[0].Equals("RegisterUser", StringComparison.OrdinalIgnoreCase);
            return lengthCondition && stringMatchCondition;
        }
    }
}
