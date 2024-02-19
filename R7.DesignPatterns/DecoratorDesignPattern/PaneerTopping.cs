namespace R7.DesignPattern.DecoratorDesignPattern
{
    internal class PaneerTopping : IPizza
    {
        IPizza _pizza;
        public PaneerTopping(IPizza pizza)
        {
            _pizza = pizza;
        }
        public string GetComposition()
        {
            return $"Paneer Topping + {_pizza.GetComposition()}";
        }

        public int GetCost()
        {
            return _pizza.GetCost() + 80;
        }
    }
}
