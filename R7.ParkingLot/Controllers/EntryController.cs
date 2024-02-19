using R7.ParkingLot.Dto;
using R7.ParkingLot.Models;
using R7.ParkingLot.Services;

namespace R7.ParkingLot.Controllers
{
    public class EntryController
    {
        private EntryService entryService = new EntryService();
        public Ticket Entry(EntryDto entryDto)
        {
            Vehicle vehicle = new Vehicle
            {
                VehicleNumber = entryDto.VehicleNumber,
                VehicleType = entryDto.VehicleType
            };
            return entryService.RegisterEntry(entryDto.GateNumber, vehicle);
        }
    }
}
