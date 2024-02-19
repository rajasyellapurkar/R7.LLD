namespace R7.DesignPattern.StrategyDesignPattern
{
    internal class NavigateRoute
    {
        private INavigateRoute _navigateRoute;

        public NavigateRoute(INavigateRoute navigateRoute)
        {
            _navigateRoute = navigateRoute;
        }

        public void BuildRoute(string source, string destination)
        {
            _navigateRoute.BuildRoute(source, destination);
        }
    }
}
