namespace SimpleFactory.Dices
{
    public class LoadedDice : IDice
    {
        private readonly int _fixedRoll;

        public LoadedDice(int fixedRoll) => _fixedRoll = fixedRoll;

        public int Roll() => _fixedRoll;
    }
}
