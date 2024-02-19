using System.Collections.Generic;

namespace R7.DesignPattern.ObserverDesignPattern
{
    internal class Bitcoin
    {
        private double _price;
        private List<IBitcoinObserver> _observers = new List<IBitcoinObserver>();

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                if ( _price != value )
                {
                    _price = value;
                    NotifyObservers();
                }
            }
        }

        private void NotifyObservers()
        {
            foreach (IBitcoinObserver observer in _observers)
            {
                observer.TakeAction();
            }
        }

        public void AddObserver(IBitcoinObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IBitcoinObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
