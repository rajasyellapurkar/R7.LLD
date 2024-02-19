namespace R7.ParkingLot.Commands
{
    public class CommandRegistry
    {
        List<ICommand> commands = new List<ICommand>();

        public void RegisterCommand(ICommand command)
        {
            commands.Add(command);
        }

        public bool UnregisterCommand(ICommand command)
        {
            return commands.Remove(command);
        }

        public void ExecuteCommand(string cmdStr)
        {
            foreach(ICommand cmd in commands)
            {
                if(cmd.Matches(cmdStr))
                {
                    cmd.Execute(cmdStr);
                }
            }
        }
    }
}
