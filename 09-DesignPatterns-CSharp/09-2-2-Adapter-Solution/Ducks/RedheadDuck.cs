namespace Adapter.Ducks
{
    using System;
    using Adapter.Fly;
    using Adapter.Quack;

    public sealed class RedheadDuck : Duck
    {
        public RedheadDuck()
            : base(new DuckQuackStrategy(), new RealFlyStrategy())
        {
        }

        public override void Display() => Console.WriteLine("Red head, gray body.");
    }
}