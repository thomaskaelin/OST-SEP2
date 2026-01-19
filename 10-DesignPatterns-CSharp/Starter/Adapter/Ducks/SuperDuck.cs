namespace Adapter.Ducks
{
    using System;
    using Adapter.Fly;
    using Adapter.Quack;

    public sealed class SuperDuck : Duck
    {
        private readonly string _appearance;

        public SuperDuck(IQuackStrategy quackStrategy, IFlyStrategy flyStrategy, string appearance)
            : base(quackStrategy, flyStrategy)
        {
            _appearance = appearance;
        }

        public override void Display() => Console.WriteLine(_appearance);
    }
}
