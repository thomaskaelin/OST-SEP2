namespace Strategy.Ducks
{
    using System;
    using Strategy.Fly;
    using Strategy.Quack;

    public sealed class ReadheadDuck : Duck
    {
        public ReadheadDuck()
            : base(new DuckQuackStrategy(), new RealFlyStrategy())
        {
        }

        public override void Display() => Console.WriteLine("Read head, gray body.");
    }
}