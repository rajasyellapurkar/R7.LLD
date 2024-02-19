using R7.ParkingLot.Models;
using R7.ParkingLot.Services;

namespace R7.ParkingLot.Controllers
{
    public class ParkingLotController
    {
        ParkingLotService service = new ParkingLotService();
        public void RegisterParking(Parking parkingLot)
        {
            service.RegisterParkingLot(parkingLot);
        }
    }
}
