namespace Adapter.Quack
{
    using System;

    public sealed class RoboticQuackStrategy : IQuackStrategy
    {
        public void Quack() => Console.WriteLine("Robotic quack quack!");
    }
}