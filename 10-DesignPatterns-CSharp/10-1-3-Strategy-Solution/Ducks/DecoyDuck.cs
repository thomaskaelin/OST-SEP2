namespace Strategy.Ducks
{
    using System;
    using Strategy.Fly;
    using Strategy.Quack;

    public sealed class DecoyDuck : Duck
    {
        public DecoyDuck()
            : base(new RoboticQuackStrategy(), new NoneFlyStrategy())
        {
        }

        public override void Display() => Console.WriteLine("Looks like mallard duck, but made from metal.");
    }
}