namespace Adapter.Ducks
{
    using System;
    using Adapter.Fly;
    using Adapter.Quack;

    public sealed class MallardDuck : Duck
    {
        public MallardDuck()
            : base(new DuckQuackStrategy(), new RealFlyStrategy())
        {
        }

        public override void Display() => Console.WriteLine("Green head, gray-brown body.");
    }
}