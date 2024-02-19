namespace R7.ParkingLot.Models
{
    public class Parking
    {
        private List<ParkingFloor> parkingFloors = [];
        private List<EntryGate> entryGates = [];
        private List<ExitGate> exitGates = [];

        private Parking() { }

        public static ParkingLotBuilder GetParkingLotBuilder()
        {
            return new ParkingLotBuilder();
        }

        public List<ParkingFloor> ParkingFloors
        {
            get { return parkingFloors; }
        }

        public class ParkingLotBuilder
        {
            private Parking parkingLot;

            public ParkingLotBuilder()
            {
                parkingLot = new Parking();
            }

            public ParkingLotBuilder WithParkingFloor(ParkingFloor parkingFloor)
            {
                parkingLot.parkingFloors.Add(parkingFloor);
                return this;
            }

            public ParkingLotBuilder WithEntryGate(EntryGate entryGate)
            {
                parkingLot.entryGates.Add(entryGate);
                return this;
            }

            public ParkingLotBuilder WithExitGate(ExitGate exitGate)
            {
                parkingLot.exitGates.Add(exitGate);
                return this;
            }

            public Parking Build()
            {
                return parkingLot;
            }
        }
    }
}
