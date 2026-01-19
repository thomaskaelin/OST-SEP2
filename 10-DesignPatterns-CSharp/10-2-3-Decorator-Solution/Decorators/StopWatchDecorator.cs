namespace Decorator.Decorators
{
    using System;
    using System.Diagnostics;

    public sealed class StopWatchDecorator : ICalculator
    {
        private readonly ICalculator _decoratedCalculator;

        public StopWatchDecorator(ICalculator decoratedCalculator)
        {
            _decoratedCalculator = decoratedCalculator;
        }

        public void Calculate()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            _decoratedCalculator.Calculate();

            stopWatch.Stop();
            Console.WriteLine($"{nameof(StopWatchDecorator)}: The decorated operation took {stopWatch.Elapsed}");
        }
    }
}
