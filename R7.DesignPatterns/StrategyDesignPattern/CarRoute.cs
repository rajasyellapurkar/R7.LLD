﻿using System;

namespace R7.DesignPattern.StrategyDesignPattern
{
    internal class CarRoute : INavigateRoute
    {
        public void BuildRoute(string source, string destination)
        {
            Console.WriteLine($"Navigating using CarRoute");
        }
    }
}
