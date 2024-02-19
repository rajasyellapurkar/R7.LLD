using R7.ParkingLot.Enums;
using R7.ParkingLot.Models;

namespace R7.ParkingLot.Services
{
    public class ParkingSlotService
    {
        private ParkingLotService _parkingLotService = new ParkingLotService();
        public ParkingSlot GetParkingSlot(VehicleType vehicleType)
        {
            return _parkingLotService.GetAvailableParkingSlots(vehicleType).FirstOrDefault();
        }
    }
}
