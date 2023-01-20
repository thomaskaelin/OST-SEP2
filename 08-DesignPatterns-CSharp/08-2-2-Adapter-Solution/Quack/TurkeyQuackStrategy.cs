namespace Adapter.Quack
{
    using Adapter.Turkeys;

    internal class TurkeyQuackStrategy : IQuackStrategy
    {
        private readonly Turkey _turkey;

        internal TurkeyQuackStrategy(Turkey turkey)
        {
            _turkey = turkey;
        }

        public void Quack() => _turkey.Gobble();
    }
}