namespace SimpleFactory
{
    using System;

    public sealed class Game
    {
        private const int PipsOnDice = 6;

        public void Play()
        {
            var dice = new Dice(PipsOnDice);

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
