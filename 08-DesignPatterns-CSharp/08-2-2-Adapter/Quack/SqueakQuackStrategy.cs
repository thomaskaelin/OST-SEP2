namespace Adapter.Quack
{
    using System;

    public sealed class SqueakQuackStrategy : IQuackStrategy
    {
        public void Quack() => Console.WriteLine("Squeak squeak!");
    }
}