namespace Adapter.Fly
{
    using System;

    public sealed class RealFlyStrategy : IFlyStrategy
    {
        public void Fly() => Console.WriteLine("Flying.");
    }
}
