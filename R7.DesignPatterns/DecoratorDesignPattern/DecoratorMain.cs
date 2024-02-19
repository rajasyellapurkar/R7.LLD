using System;

namespace R7.DesignPattern.DecoratorDesignPattern
{
    internal class DecoratorMain
    {
        public static void Entry()
        {
            IPizza pizza = new TomatoTopping(
                             new CheeseTopping(
                                new Pizza()));

            Console.WriteLine(pizza.GetComposition());
            Console.WriteLine(pizza.GetCost());
        }
    }
}
