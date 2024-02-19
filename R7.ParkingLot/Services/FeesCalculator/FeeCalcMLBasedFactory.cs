using R7.ParkingLot.Enums;
using R7.ParkingLot.Services.FeesCalculator.MLBasedStrategies;
using R7.ParkingLot.Services.FeesCalculator.TimeBasedStrategies;

namespace R7.ParkingLot.Services.FeesCalculator
{
    public class FeeCalcMLBasedFactory: IFeeCalcFactory
    {
        public IFeeCalcStrategy GetFeeCalcStrategy(VehicleType vehicleType)
        {
            IFeeCalcStrategy? feeCalcStrategy = null;
            switch (vehicleType)
            {
                case VehicleType.Small:
                    feeCalcStrategy = new SmallVehicleMLBasedStrategy();
                    break;
            }
            return feeCalcStrategy ?? throw new Exception("Invalid vehicle type");
        }
    }
}
