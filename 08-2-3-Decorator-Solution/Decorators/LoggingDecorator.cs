namespace Decorator.Decorators
{
    using System;

    public sealed class LoggingDecorator : ICalculator
    {
        private readonly ICalculator _decoratedCalculator;

        public LoggingDecorator(ICalculator decoratedCalculator)
        {
            _decoratedCalculator = decoratedCalculator;
        }

        public void Calculate()
        {
            Console.WriteLine($"{nameof(LoggingDecorator)}: Before calling the decorated object");
            _decoratedCalculator.Calculate();
            Console.WriteLine($"{nameof(LoggingDecorator)}: After calling the decorated object");
        }
    }
}
