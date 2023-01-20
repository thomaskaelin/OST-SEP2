namespace Adapter.Quack
{
    using System;

    public sealed class DuckQuackStrategy : IQuackStrategy
    {
        public void Quack() => Console.WriteLine("Quack quack quack!");
    }
}