namespace Adapter.Ducks
{
    using System;
    using Adapter.Fly;
    using Adapter.Quack;

    public sealed class RubberDuck : Duck
    {
        public RubberDuck()
            : base(new SqueakQuackStrategy(), new NoneFlyStrategy())
        {
        }

        public override void Display() => Console.WriteLine("All yellow, made from rubber.");
    }
}