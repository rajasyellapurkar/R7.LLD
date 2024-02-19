using R7.SnakeAndLadders.Commands.Interface;
using R7.SnakeAndLadders.Exceptions;

namespace R7.SnakeAndLadders.Commands
{
    public class CommandRegistry
    {
        private List<ICommand> _commands = new List<ICommand>();

        public void RegisterCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void Execute(string commandStr)
        {
            foreach(ICommand command in  _commands)
            {
                if (command.Matches(commandStr))
                {
                    command.Execute();
                    return;
                }
            }
            throw new InvalidCommandException();
        }
    }
}
