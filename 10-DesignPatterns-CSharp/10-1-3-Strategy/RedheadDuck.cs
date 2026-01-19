namespace Strategy
{
    using System;

    public sealed class RedheadDuck : Duck
    {
        public override void Display() => Console.WriteLine("Red head, gray body.");
    }
}