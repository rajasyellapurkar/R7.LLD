using R7.ParkingLot.Enums;

namespace R7.ParkingLot.Dto
{
    public class EntryDto
    {
        public int GateNumber { get; set; }
        public string VehicleNumber { get; set; }
        public VehicleType VehicleType { get; set; }
    }
}
