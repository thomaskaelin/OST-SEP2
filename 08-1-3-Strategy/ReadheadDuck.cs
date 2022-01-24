namespace Strategy
{
    using System;

    public sealed class ReadheadDuck : Duck
    {
        public override void Display() => Console.WriteLine("Read head, gray body.");
    }
}