namespace R7.DesignPattern.DependencyInversion
{
    internal class PaytmPaymentProcessor
    {
        readonly IPaymentProcessor _paymentProcessor;

        public PaytmPaymentProcessor(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }
        public void Pay()
        {
            _paymentProcessor.Pay();
        }
    }
}
