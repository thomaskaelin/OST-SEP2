namespace Strategy
{
    using System;
    using System.Collections.Generic;
    using Strategy.Ducks;
    using Strategy.Fly;
    using Strategy.Quack;

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
                new ReadheadDuck(), 
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
