namespace R7.ParkingLot.Commands
{
    public interface ICommand
    {
        bool Matches(string command);

        void Execute(string command);
    }
}
