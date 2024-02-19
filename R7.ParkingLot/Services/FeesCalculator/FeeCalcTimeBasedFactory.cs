using R7.ParkingLot.Enums;
using R7.ParkingLot.Services.FeesCalculator.TimeBasedStrategies;

namespace R7.ParkingLot.Services.FeesCalculator
{
    public class FeeCalcTimeBasedFactory : IFeeCalcFactory
    {
        public IFeeCalcStrategy GetFeeCalcStrategy(VehicleType vehicleType)
        {
            IFeeCalcStrategy? feeCalcStrategy = null;
            switch(vehicleType)
            {
                case VehicleType.Small:
                    feeCalcStrategy = new SmallVehicleTimeBasedStrategy();
                    break;
                case VehicleType.Medium:
                    feeCalcStrategy = new MediumVehicleTimeBasedStrategy();
                    break;
                case VehicleType.Large:
                    feeCalcStrategy = new HeavyVehicleTimeBasedStrategy();
                    break;
            }
            return feeCalcStrategy ?? throw new Exception("Invalid vehicle type");
        }
    }
}
