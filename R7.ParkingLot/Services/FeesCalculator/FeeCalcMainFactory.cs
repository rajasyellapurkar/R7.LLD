namespace R7.ParkingLot.Services.FeesCalculator
{
    public class FeeCalcMainFactory : IFeeCalcMainFactory
    {
        public IFeeCalcFactory GetFeeCalcFactory(string strategyType)
        {
            if (strategyType == "ML")
            {
                return new FeeCalcMLBasedFactory();
            }
            else
            {
                return new FeeCalcTimeBasedFactory();
            }
        }
    }
}
