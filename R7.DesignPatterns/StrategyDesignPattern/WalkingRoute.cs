using System;

namespace R7.DesignPattern.StrategyDesignPattern
{
    internal class WalkingRoute : INavigateRoute
    {
        public void BuildRoute(string source, string destination)
        {
            Console.WriteLine($"Navigating using Walking route");
        }
    }
}
