using R7.DesignPattern.AdapterPattern.ExternalApis;
using R7.DesignPatterns.AdapterPattern;

namespace R7.DesignPattern.AdapterPattern.Adapters
{
    internal class JustPayAdapter: IPaymentProcessor
    {
        private JustPayApi _justPayApi;
        public JustPayAdapter() 
        { 
            _justPayApi = new JustPayApi();
        }

        public string GenerateLink()
        {
           return _justPayApi.CreateLink();
        }

        public string GetPaymentStatus()
        {
            return _justPayApi.Status();
        }

        public string ProcessPayment()
        {
            return _justPayApi.Pay();
        }
    }
}
