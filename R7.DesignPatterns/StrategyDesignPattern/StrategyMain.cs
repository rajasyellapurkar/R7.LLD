namespace R7.DesignPattern.StrategyDesignPattern
{
    internal class StrategyMain
    {
        public static void Entry()
        {
            INavigateRoute routeStrategy = new WalkingRoute();

            NavigateRoute route = new NavigateRoute(routeStrategy);

            route.BuildRoute("VS", "CBR");
        }
    }
}
