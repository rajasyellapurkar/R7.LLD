using System;

namespace R7.DesignPattern.ObserverDesignPattern
{
    internal class Purchase : IBitcoinObserver
    {
        public void TakeAction()
        {
            Console.WriteLine($"Purchasing bitcoin when price changed");
        }
    }
}
