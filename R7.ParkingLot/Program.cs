using R7.ParkingLot.Commands;
using R7.ParkingLot.Controllers;
using R7.ParkingLot.Models;

namespace R7.ParkingLot
{
    internal class Program
    {
        private static CommandRegistry commandRegistry = new CommandRegistry();
        static void Main(string[] args)
        {
            InitializeParkingLot();

            RegisterCommands();

            while(true)
            {
                string command = Console.ReadLine();
                if(command == string.Empty)
                {
                    break;
                }
                commandRegistry.ExecuteCommand(command);
            }
        }

        private static void RegisterCommands()
        {
            commandRegistry.RegisterCommand(new EntryCommand());
        }

        private static void InitializeParkingLot()
        {
            ParkingFloor parkingFloor = ParkingFloor.GetParkingFloorBuilder()
                                                                .WithParkingSlots(new List<ParkingSlot>
                                                                {
                                                        new ParkingSlot(Enums.VehicleType.Small) { Number = 1 },
                                                        new ParkingSlot(Enums.VehicleType.Large) { Number = 2 }
                                                                })
                                                                .WithFloorNumber(0)
                                                                .Build();
            Parking parkingLot = Models.Parking.GetParkingLotBuilder()
                                                            .WithParkingFloor(parkingFloor)
                                                            .WithEntryGate(new EntryGate
                                                            {
                                                                Id = 1,
                                                                Operator = new Operator
                                                                {
                                                                    Name = "Raj"
                                                                }
                                                            })
                                                            .WithExitGate(new ExitGate
                                                            {
                                                                Id = 2,
                                                                Operator = new Operator
                                                                {
                                                                    Name = "Sham"
                                                                }
                                                            })
                                                            .Build();
            ParkingLotController parkingLotController = new ParkingLotController();
            parkingLotController.RegisterParking(parkingLot);
        }
    }
}
