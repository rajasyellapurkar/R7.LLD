namespace R7.ParkingLot.Models
{
    public class ParkingFloor
    {
        private int floorNo;
        private List<ParkingSlot> parkingSlots = new List<ParkingSlot>();

        private ParkingFloor() { }

        public List<ParkingSlot> ParkingSlots { get { return parkingSlots; } }

        public static ParkingFloorBuilder GetParkingFloorBuilder()
        {
            return new ParkingFloorBuilder();
        }

        public class ParkingFloorBuilder
        {
            private ParkingFloor parkingFloor;

            public ParkingFloorBuilder()
            {
                parkingFloor = new ParkingFloor();
            }

            public ParkingFloorBuilder WithParkingSlots(List<ParkingSlot> parkingSlots)
            {
                parkingFloor.parkingSlots.AddRange(parkingSlots);
                return this;
            }

            public ParkingFloorBuilder WithFloorNumber(int floorNumber)
            {
                parkingFloor.floorNo = floorNumber;
                return this;
            }

            public ParkingFloor Build()
            {
                return parkingFloor;
            }
        }
    }
}
