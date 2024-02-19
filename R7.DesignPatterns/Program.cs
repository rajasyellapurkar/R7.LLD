using R7.DesignPattern.AdapterPattern;
using R7.DesignPattern.BuilderDesignPattern;
using R7.DesignPattern.DecoratorDesignPattern;
using R7.DesignPattern.DependencyInversion;
using R7.DesignPattern.FactoryDesignPattern.AbstractFactory;
using R7.DesignPattern.FactoryDesignPattern.FactoryMethod;
using R7.DesignPattern.FactoryDesignPattern.NoFactory;
using R7.DesignPattern.FlyweightDesignPattern;
using R7.DesignPattern.InterfaceOverInheritance;
using R7.DesignPattern.InterfaceOverInheritance.SoundBehaviour;
using R7.DesignPattern.InterfaceOverInheritance.WalkingBehaviour;
using R7.DesignPattern.ObserverDesignPattern;
using R7.DesignPattern.PrototypeDesignPattern;
using R7.DesignPattern.StrategyDesignPattern;
using System;
using System.Collections.Generic;

namespace R7.DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- First Design Principle - Prefer Composition over Inheritance --------------------");
            Cat cat = new Cat(new SlowWalkingBehaviour(), new SilentSoundBehaviour());
            Dog dog = new Dog(new FastWalkingBehaviour());
            Monkey monkey = new Monkey(new FastWalkingBehaviour());

            List<IWalkable> walkingAnimals = new List<IWalkable>{
                cat, dog, monkey
            };

            List<ISound> soundAnimals = new List<ISound> { cat };

            walkingAnimals.ForEach(_ => _.Walk());

            soundAnimals.ForEach(_ => _.MakeSound());

            Console.WriteLine("--------------- Dependency Inversion (D in SOLID) --------------------");

            PaytmPaymentProcessor paytmPaymentProcessor = new PaytmPaymentProcessor(new JustPayPayment());
            paytmPaymentProcessor.Pay();

            Console.WriteLine("--------------- Builder Design Pattern --------------------");

            Student student = Student.GetBuilder()
                                     .SetId(123)
                                     .SetName("Rajas")
                                     .SetLastName("Yellapurkar")
                                     .SetDoB(DateTime.Now)
                                     .ValidateAndBuild();
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);

            Console.WriteLine("--------------- Factory Design Pattern --------------------");
            NoFactoryMain.Entry();
            FactoryMethodMain.Entry();
            AbstractFactoryMain.Entry();

            Console.WriteLine("--------------- Prototype Design Pattern --------------------");
            PrototypeMain.Entry();

            Console.WriteLine("--------------- Adapter Design Pattern ----------------------");
            AdapterMain.Entry();

            Console.WriteLine("--------------- Flyweight Design Pattern ----------------------");
            FlyweightMain.Entry();

            Console.WriteLine("--------------- Decorator Design Pattern ----------------------");
            DecoratorMain.Entry();

            Console.WriteLine("--------------- Observer Design Pattern ----------------------");
            ObserverMain.Entry();

            Console.WriteLine("--------------- Strategy Design Pattern ----------------------");
            StrategyMain.Entry();
        }
    }
}