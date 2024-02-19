using R7.ParkingLot.Models;

namespace R7.ParkingLot.Services.FeesCalculator.MLBasedStrategies
{
    public class SmallVehicleMLBasedStrategy : IFeeCalcStrategy
    {
        public double CalculateFees(Ticket ticket)
        {
            TimeSpan diff = ticket.EndTime - ticket.StartTime;
            return diff.TotalHours * 15; // x factor to check if it is the peak time
        }
    }
}
