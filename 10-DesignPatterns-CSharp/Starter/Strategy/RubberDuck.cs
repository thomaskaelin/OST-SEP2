namespace Strategy
{
    using System;

    public sealed class RubberDuck : Duck
    {
        public override void Quack() => Console.WriteLine("Squeak squeak!");

        public override void Display() => Console.WriteLine("All yellow, made from rubber.");

        public override void Fly() => Console.WriteLine("Can not fly, not real.");
    }
}