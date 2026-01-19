namespace Adapter.Ducks
{
    using System;

    using Adapter.Fly;
    using Adapter.Quack;
    using Adapter.Turkeys;

    public class TurkeyAdapter : Duck
    {
        private readonly Turkey _turkey;

        public TurkeyAdapter(Turkey turkey) : base(new TurkeyQuackStrategy(turkey), new TurkeyFlyStrategy(turkey))
        {
            _turkey = turkey;
        }

        public override void Swim() => _turkey.Swim();

        public override void Display() => Console.WriteLine("I am a Turkey hiding at the Duck Pond.");
    }
}
