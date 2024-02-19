namespace R7.DesignPattern.DecoratorDesignPattern
{
    internal class Pizza : IPizza
    {
        public string GetComposition()
        {
            return $"Pizza Base";
        }

        public int GetCost()
        {
            return 50;
        }
    }
}
