using R7.ParkingLot.Models;

namespace R7.ParkingLot.Services.FeesCalculator
{
    public interface IFeeCalcStrategy
    {
        double CalculateFees(Ticket ticket);
    }
}
