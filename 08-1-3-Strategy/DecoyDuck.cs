namespace Strategy
{
    using System;

    public sealed class DecoyDuck : Duck
    {
        public override void Quack() => Console.WriteLine("Robotic quack quack!");

        public override void Display() => Console.WriteLine("Looks like mallard duck, but made from metal.");

        public override void Fly() => Console.WriteLine("Can not fly, not real.");
    }
}