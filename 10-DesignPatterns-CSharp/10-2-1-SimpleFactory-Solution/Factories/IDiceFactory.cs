namespace SimpleFactory.Factories
{
    using SimpleFactory.Dices;

    public interface IDiceFactory
    {
        public IDice CreateDice(int pipsOnDice);
    }
}
