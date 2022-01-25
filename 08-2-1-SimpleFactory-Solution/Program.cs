namespace SimpleFactory
{
    using System;
    using SimpleFactory.Factories;
    
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main(string[] args)
        {
            var diceFactory = new DiceFactory();
            var loadedDiceFactory = new LoadedDiceFactory();

            var game = new Game(loadedDiceFactory);

            for (var i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Playing game #{i}");
                game.Play();
            }
        }
    }
}
