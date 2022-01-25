namespace Adapter.Ducks
{
    using System;
    using Adapter.Fly;
    using Adapter.Quack;

    public abstract class Duck
    {
        private readonly IQuackStrategy _quackStrategy;
        private readonly IFlyStrategy _flyStrategy;

        protected Duck(
            IQuackStrategy quackStrategy,
            IFlyStrategy flyStrategy)
        {
            _quackStrategy = quackStrategy;
            _flyStrategy = flyStrategy;
        }

        public void Quack() => _quackStrategy.Quack();

        public void Swim() => Console.WriteLine("Swimming.");

        public void Fly() => _flyStrategy.Fly();

        public abstract void Display();
    }
}
