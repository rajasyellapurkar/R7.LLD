namespace R7.DesignPatterns.AdapterPattern
{
    internal interface IPaymentProcessor
    {
        string GenerateLink();
        string ProcessPayment();
        string GetPaymentStatus();
    }
}
