namespace SimpleFactory.Factories
{
    using SimpleFactory.Dices;

    public sealed class LoadedDiceFactory : IDiceFactory
    {
        public IDice CreateDice(int pipsOnDice) => new LoadedDice(pipsOnDice);
    }
}
