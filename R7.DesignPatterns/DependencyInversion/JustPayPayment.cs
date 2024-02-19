using System;

namespace R7.DesignPattern.DependencyInversion
{
    internal class JustPayPayment : IPaymentProcessor
    {
        private void MakePayment()
        {
            Console.WriteLine("Make Payment of JustPay Payment");
        }

        public void Pay()
        {
            MakePayment();
        }
    }
}
