using System;

namespace R7.DesignPattern.ObserverDesignPattern
{
    internal class Tweeter : IBitcoinObserver
    {
        public void TakeAction()
        {
            Console.WriteLine($"Sending tweet when price changed for Bitcoin");
        }
    }
}
