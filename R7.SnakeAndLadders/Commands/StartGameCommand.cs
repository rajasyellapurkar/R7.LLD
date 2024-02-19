using R7.SnakeAndLadders.Commands.Interface;

namespace R7.SnakeAndLadders.Commands
{
    internal class StartGameCommand : ICommand
    {
        public void Execute()
        {
            
        }

        public bool Matches(string command)
        {
            return true;
        }
    }
}
