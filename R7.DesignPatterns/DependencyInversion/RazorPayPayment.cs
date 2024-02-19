using System;

namespace R7.DesignPattern.DependencyInversion
{
    internal class RazorPayPayment: IPaymentProcessor
    {
        private void GenerateLink()
        {
            Console.WriteLine("Generate link method of Razor Pay");
        }

        private void Payment()
        {
            Console.WriteLine("Inside Razor Pay pay method");
        }

        public void Pay()
        {
            GenerateLink();
            Payment();
        }
    }
}
