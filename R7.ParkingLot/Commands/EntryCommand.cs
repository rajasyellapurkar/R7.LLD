using R7.ParkingLot.Controllers;
using R7.ParkingLot.Dto;
using R7.ParkingLot.Enums;
using R7.ParkingLot.Models;

namespace R7.ParkingLot.Commands
{
    public class EntryCommand : ICommand
    {
        public void Execute(string command)
        {
            string[] commands = command.Split(' ');
            int entryGateNumber;
            VehicleType vehicleType;
            if (!int.TryParse(commands[1], out entryGateNumber))
            {
                throw new Exception("Unable to parse the Entry gate number");
            }
            if (!Enum.TryParse(commands[3], out vehicleType))
            {
                throw new Exception("Invalid Vehicle type. Failed to parse the vehicle type");
            }
            EntryDto entryDto = new EntryDto
            {
                GateNumber = entryGateNumber,
                VehicleType = vehicleType,
                VehicleNumber = commands[2]
            };
            EntryController entryController = new EntryController();
            Ticket ticket = entryController.Entry(entryDto);

            Console.WriteLine($"Ticket Number: {ticket.Id}");
            Console.WriteLine($"Ticket Entry time: {ticket.StartTime}");
            Console.WriteLine($"Parking Slot Number: {ticket.ParkingSlotId}");
        }

        public bool Matches(string command)
        {
            string[] commands = command.Split(' ');
            if (commands.Length == 4 && commands[0].ToLower() == "entry")
            {
                return true;
            }
            return false;
        }
    }
}
