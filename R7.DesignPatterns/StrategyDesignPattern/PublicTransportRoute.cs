using System;

namespace R7.DesignPattern.StrategyDesignPattern
{
    internal class PublicTransportRoute : INavigateRoute
    {
        public void BuildRoute(string source, string destination)
        {
            Console.WriteLine("Navigating using Public transport mode");
        }
    }
}
