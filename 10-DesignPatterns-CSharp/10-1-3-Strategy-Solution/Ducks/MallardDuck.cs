namespace Strategy.Ducks
{
    using System;
    using Strategy.Fly;
    using Strategy.Quack;

    public sealed class MallardDuck : Duck
    {
        public MallardDuck()
            : base(new DuckQuackStrategy(), new RealFlyStrategy())
        {
        }

        public override void Display() => Console.WriteLine("Green head, gray-brown body.");
    }
}