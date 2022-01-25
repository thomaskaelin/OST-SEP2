namespace Adapter.Fly
{
    using System;

    public sealed class NoneFlyStrategy : IFlyStrategy
    {
        public void Fly() => Console.WriteLine("Can not fly, not real.");
    }
}
