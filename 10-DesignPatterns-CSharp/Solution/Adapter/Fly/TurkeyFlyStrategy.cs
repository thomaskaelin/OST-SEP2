namespace Adapter.Fly
{
    using Adapter.Turkeys;

    internal sealed class TurkeyFlyStrategy : IFlyStrategy
    {
        private readonly Turkey _turkey;

        internal TurkeyFlyStrategy(Turkey turkey)
        {
            _turkey = turkey;
        }

        public void Fly()
        {
            for (var i = 1; i <= 5; i++)
                _turkey.Flutter();
        }
    }
}
