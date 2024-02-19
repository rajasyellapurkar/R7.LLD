namespace R7.DesignPattern.AdapterPattern.ExternalApis
{
    /// <summary>
    /// In real world scenario this class would be implemented by RazorPay Developers
    /// </summary>
    internal class RazorPayApi
    {
        public string MakeLink()
        {
            return $"{this.GetType().Name} make link";
        }

        public string ExecutePayment()
        {
            return $"{GetType().Name}.Execute Payment";
        }

        public string StatusCheck()
        {
            return $"{GetType().Name}.StatusCheck";
        }
    }
}
