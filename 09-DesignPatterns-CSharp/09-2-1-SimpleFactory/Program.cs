namespace SimpleFactory
{
    using System;

    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main(string[] args)
        {
            var game = new Game();

            for (var i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Playing game #{i}");
                game.Play();
            }
        }
    }
}
