namespace Strategy.Ducks
{
    using System;
    using Strategy.Fly;
    using Strategy.Quack;

    public sealed class RubberDuck : Duck
    {
        public RubberDuck()
            : base(new SqueakQuackStrategy(), new NoneFlyStrategy())
        {
        }

        public override void Display() => Console.WriteLine("All yellow, made from rubber.");
    }
}