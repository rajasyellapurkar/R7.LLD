using R7.ParkingLot.Enums;
using R7.ParkingLot.Models;
using R7.ParkingLot.Repositories;

namespace R7.ParkingLot.Services
{
    public class ParkingLotService
    {
        ParkingLotRepository _repository = ParkingLotRepository.GetInstance();

        public void RegisterParkingLot(Parking parkingLot)
        {
            _repository.InsertParkingLot(parkingLot);
        }

        public IList<ParkingSlot> GetAvailableParkingSlots(VehicleType vehicleType) 
        {
            IList<ParkingSlot> parkingSlots = _repository.GetParkingSlots();
            return parkingSlots.Where(ps => ps.ParkingSlotType == vehicleType && !ps.IsOccupied).ToList();
        }
    }
}
