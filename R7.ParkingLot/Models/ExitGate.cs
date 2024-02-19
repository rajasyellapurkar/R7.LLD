namespace R7.ParkingLot.Models
{
    public class ExitGate: Gate
    {
        public bool CanExit(Ticket ticket)
        {
            // Determine the fees
            // Call the fee calculation strategy
            // Compare fees with amount paid
            // If Amount paid is equal to the fee then exit is true
            return false;
        }
    }
}
