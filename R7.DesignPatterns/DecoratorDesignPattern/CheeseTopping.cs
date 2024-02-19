namespace R7.DesignPattern.DecoratorDesignPattern
{
    internal class CheeseTopping : IPizza
    {
        IPizza _pizza;
        public CheeseTopping(IPizza pizza)
        {
            _pizza = pizza;
        }
        public string GetComposition()
        {
            return $"Cheese Topping + {_pizza.GetComposition()}";
        }

        public int GetCost()
        {
            return _pizza.GetCost() + 100;
        }
    }
}
