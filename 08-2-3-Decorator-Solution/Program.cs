namespace Decorator
{
    using Decorator.Decorators;

    // ReSharper disable once ClassNeverInstantiated.Global
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var calculator = new Calculator();
            var stopWatchCalculator = new StopWatchDecorator(calculator);
            var loggingCalculator = new LoggingDecorator(stopWatchCalculator);

            loggingCalculator.Calculate();
        }
    }
}
