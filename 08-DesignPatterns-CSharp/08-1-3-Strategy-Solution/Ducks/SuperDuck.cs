namespace Strategy.Ducks
{
    using System;
    using Strategy.Fly;
    using Strategy.Quack;

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
