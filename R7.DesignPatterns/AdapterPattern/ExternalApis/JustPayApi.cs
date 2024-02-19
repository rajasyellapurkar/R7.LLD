namespace R7.DesignPattern.AdapterPattern.ExternalApis
{
    /// <summary>
    /// In real world scenario this class implementation would be done by JustPay company developers
    /// </summary>
    internal class JustPayApi
    {
        public string CreateLink()
        {
            return $"{GetType().Name}.GenerateLink";
        }

        public string Pay()
        {
            return $"{GetType().Name}.Pay";
        }

        public string Status()
        {
            return $"{GetType().Name}.Status";
        }
    }
}
