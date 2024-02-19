using R7.ParkingLot.Models;

namespace R7.ParkingLot.Services
{
    public class EntryService
    {
        private ParkingSlotService _parkingSlotService = new ParkingSlotService();
        public Ticket RegisterEntry(int entryGate, Vehicle vehicle)
        {
            ParkingSlot parkingSlot = _parkingSlotService.GetParkingSlot(vehicle.VehicleType);
            Ticket ticket = IssueTicket();
            ticket.ParkingSlotId = parkingSlot.Number;
            ticket.EntryGateNumber = entryGate;
            return ticket;
        }

        private Ticket IssueTicket()
        {
            return new Ticket
            {
                StartTime = DateTime.Now,
                Status = Enums.PaymentStatus.UNPAID,
                Id = Guid.NewGuid().ToString(),
                EndTime = DateTime.MaxValue
            };
        }
    }
}
