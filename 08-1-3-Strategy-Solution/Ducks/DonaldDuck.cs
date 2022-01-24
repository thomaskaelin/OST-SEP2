namespace Strategy.Ducks
{
    using System;
    using Strategy.Fly;
    using Strategy.Quack;

    public sealed class DonaldDuck : Duck
    {
        public DonaldDuck()
            : base(new HumanQuackStrategy(), new NoneFlyStrategy())
        {
        }

        public override void Display() => Console.WriteLine("Looks like taken from a comic book.");
    }
}