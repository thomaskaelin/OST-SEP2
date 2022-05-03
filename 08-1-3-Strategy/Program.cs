namespace Strategy
{
    using System;
    using System.Collections.Generic;

    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    { 
        public static void Main(string[] args)
        {
            var ducks = new List<Duck>
            {
                new MallardDuck(), 
                new RedheadDuck(), 
                new RubberDuck(), 
                new DecoyDuck()
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
