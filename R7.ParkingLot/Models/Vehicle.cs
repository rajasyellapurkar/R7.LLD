using R7.ParkingLot.Enums;

namespace R7.ParkingLot.Models
{
    public class Vehicle
    {
        public string VehicleNumber { get; set; } = null!;
        public VehicleType VehicleType { get; set; }
    }
}
