namespace Adapter.Quack
{
    using System;

    public sealed class HumanQuackStrategy : IQuackStrategy
    {
        public void Quack() => Console.WriteLine("Hi there, I am able to speak!");
    }
}