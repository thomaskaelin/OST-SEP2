namespace Adapter
{
    using System;
    using System.Collections.Generic;
    using Adapter.Ducks;
    using Adapter.Fly;
    using Adapter.Quack;

    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    { 
        public static void Main(string[] args)
        {
            var superDuckConfiguredLikeMallardDuck = new SuperDuck(
                new DuckQuackStrategy(),
                new RealFlyStrategy(),
                "Green head, gray-brown body - like the mallard duck!");

            var ducks = new List<Duck>
            {
                new MallardDuck(), 
                new RedheadDuck(), 
                new RubberDuck(), 
                new DecoyDuck(),
                new DonaldDuck(),
                superDuckConfiguredLikeMallardDuck
            };

            ducks.ForEach(InteractWithDuck);
        }

        private static void InteractWithDuck(Duck duck)
        {
            duck.Display();
            duck.Quack();
            duck.Swim();
            duck.Fly();
            Console.WriteLine("-----------------");
        }
    }
}
