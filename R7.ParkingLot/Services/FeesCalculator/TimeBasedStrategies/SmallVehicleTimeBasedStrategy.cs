using R7.ParkingLot.Models;

namespace R7.ParkingLot.Services.FeesCalculator.TimeBasedStrategies
{
    public class SmallVehicleTimeBasedStrategy : IFeeCalcStrategy
    {
        public double CalculateFees(Ticket ticket)
        {
            TimeSpan diff = ticket.EndTime - ticket.StartTime;
            return diff.TotalHours * 15;
        }
    }
}
