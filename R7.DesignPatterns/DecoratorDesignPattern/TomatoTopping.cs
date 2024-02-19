namespace R7.DesignPattern.DecoratorDesignPattern
{
    internal class TomatoTopping: IPizza
    {
        IPizza _pizza;
        public TomatoTopping(IPizza pizza)
        {
            _pizza = pizza;
        }

        public string GetComposition()
        {
            return $"Tomato Topping + {_pizza.GetComposition()}";
        }

        public int GetCost()
        {
            return _pizza.GetCost() + 50;
        }
    }
}
