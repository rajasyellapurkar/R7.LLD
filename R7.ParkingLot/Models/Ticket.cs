using R7.ParkingLot.Enums;

namespace R7.ParkingLot.Models
{
    public class Ticket
    {
        public int EntryGateNumber { get; set; }
        public string Id { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public PaymentStatus Status { get; set; }
        public int ParkingSlotId { get; set; }
    }
}
