namespace R7.ParkingLot.Services.FeesCalculator
{
    public interface IFeeCalcMainFactory
    {
        IFeeCalcFactory GetFeeCalcFactory(string strategyType);
    }
}
