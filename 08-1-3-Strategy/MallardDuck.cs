namespace Strategy
{
    using System;

    public sealed class MallardDuck : Duck
    {
        public override void Display() => Console.WriteLine("Green head, gray-brown body.");
    }
}