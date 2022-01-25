namespace SimpleFactory
{
    using System;

    public sealed class Dice
    {
        private readonly int _maxPips;
        private readonly Random _random;

        public Dice(int maxPips)
        {
            _maxPips = maxPips;
            _random = new Random();
        }

        public int Roll()
        {
            var roll = _random.Next(1, _maxPips + 1);

            return roll;
        }
    }

}
