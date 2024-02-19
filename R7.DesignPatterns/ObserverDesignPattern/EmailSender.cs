using System;

namespace R7.DesignPattern.ObserverDesignPattern
{
    internal class EmailSender: IBitcoinObserver
    {
        public void TakeAction()
        {
            Console.WriteLine($"Sending email when price change for Bitcoin");
        }
    }
}
