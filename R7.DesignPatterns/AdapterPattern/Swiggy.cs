using R7.DesignPatterns.AdapterPattern;
using System;

namespace R7.DesignPattern.AdapterPattern
{
    internal class Swiggy
    {
        IPaymentProcessor _paymentProcessor;
        public Swiggy(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;  
        }

        public void Pay()
        {
            Console.WriteLine(_paymentProcessor.GenerateLink());
            Console.WriteLine(_paymentProcessor.ProcessPayment());
            Console.WriteLine(_paymentProcessor.GetPaymentStatus());
        }
    }
}
