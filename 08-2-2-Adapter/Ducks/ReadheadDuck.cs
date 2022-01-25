namespace Adapter.Ducks
{
    using System;
    using Adapter.Fly;
    using Adapter.Quack;

    public sealed class ReadheadDuck : Duck
    {
        public ReadheadDuck()
            : base(new DuckQuackStrategy(), new RealFlyStrategy())
        {
        }

        public override void Display() => Console.WriteLine("Read head, gray body.");
    }
}