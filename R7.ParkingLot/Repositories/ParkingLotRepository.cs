using R7.ParkingLot.Models;

namespace R7.ParkingLot.Repositories
{
    public class ParkingLotRepository
    {
        private ParkingLotRepository() { }
        private Parking? parking;
        private static ParkingLotRepository parkingLotRepo = new ParkingLotRepository();

        public static ParkingLotRepository GetInstance() { return parkingLotRepo; }
        public void InsertParkingLot(Parking parking)
        {
            this.parking = parking;
        }
        public List<ParkingSlot> GetParkingSlots()
        {
            return parking.ParkingFloors.SelectMany(pf => pf.ParkingSlots).ToList();
        }
    }
}
