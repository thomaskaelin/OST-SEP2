namespace SimpleFactory.Factories
{
    using SimpleFactory.Dices;

    public sealed class DiceFactory : IDiceFactory
    {
        public IDice CreateDice(int pipsOnDice) => new Dice(pipsOnDice);
    }
}
