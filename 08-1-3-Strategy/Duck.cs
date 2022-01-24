// ReSharper disable VirtualMemberNeverOverridden.Global
namespace Strategy
{
    using System;

    public abstract class Duck
    {
        public virtual void Quack() => Console.WriteLine("Quack quack quack!");

        public virtual void Swim() => Console.WriteLine("Swimming.");

        public virtual void Fly() => Console.WriteLine("Flying.");

        public abstract void Display();
    }
}
