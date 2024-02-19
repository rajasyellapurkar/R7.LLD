namespace R7.SnakeAndLadders.Commands.Interface
{
    public interface ICommand
    {
        bool Matches(string command);
        void Execute();
    }
}
