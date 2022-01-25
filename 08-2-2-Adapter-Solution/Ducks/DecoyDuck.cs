namespace Adapter.Ducks
{
    using System;
    using Adapter.Fly;
    using Adapter.Quack;

    public sealed class DecoyDuck : Duck
    {
        public DecoyDuck()
            : base(new RoboticQuackStrategy(), new NoneFlyStrategy())
        {
        }

        public override void Display() => Console.WriteLine("Looks like mallard duck, but made from metal.");
    }
}