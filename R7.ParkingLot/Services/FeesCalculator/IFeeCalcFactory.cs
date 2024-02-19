using R7.ParkingLot.Enums;

namespace R7.ParkingLot.Services.FeesCalculator
{
    public interface IFeeCalcFactory
    {
        IFeeCalcStrategy GetFeeCalcStrategy(VehicleType vehicleType);
    }
}
