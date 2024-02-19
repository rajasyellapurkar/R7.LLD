using R7.DesignPattern.AdapterPattern.ExternalApis;
using R7.DesignPatterns.AdapterPattern;

namespace R7.DesignPattern.AdapterPattern.Adapters
{
    internal class RazorPayAdapter : IPaymentProcessor
    {
        RazorPayApi _razorPayApi;
        public RazorPayAdapter()
        {
            _razorPayApi = new RazorPayApi();
        }
        public string GenerateLink()
        {
            return _razorPayApi.MakeLink();
        }

        public string ProcessPayment()
        {
            return _razorPayApi.ExecutePayment();
        }

        public string GetPaymentStatus()
        {
            return _razorPayApi.StatusCheck();
        }
    }
}
