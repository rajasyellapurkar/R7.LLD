using R7.ParkingLot.Enums;

namespace R7.ParkingLot.Models
{
    public class ParkingSlot
    {
        public VehicleType ParkingSlotType { get; init; }
        public int Number { get; set; }
        public bool IsOccupied { get; private set; }

        public ParkingSlot(VehicleType parkingSlotType)
        {
            ParkingSlotType = parkingSlotType;
        }

        internal void OnOccupied(bool isOccupied)
        {
            IsOccupied = isOccupied;
        }
    }
}
