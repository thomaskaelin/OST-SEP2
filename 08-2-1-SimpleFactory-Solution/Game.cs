namespace SimpleFactory
{
    using System;

    using SimpleFactory.Factories;

    public sealed class Game
    {
        private const int PipsOnDice = 6;
        private readonly IDiceFactory _diceFactory;

        public Game(IDiceFactory diceFactory)
        {
            _diceFactory = diceFactory;
        }

        public void Play()
        {
            var dice = _diceFactory.CreateDice(PipsOnDice);

            var roll1 = dice.Roll();
            var roll2 = dice.Roll();
            var sum = roll1 + roll2;
            var hasWon = sum == 2 * PipsOnDice;
            var message = hasWon ? "You win!" : "You loose!";

            Print(message);
        }

        private static void Print(string message) => Console.WriteLine(message);
    }
}
