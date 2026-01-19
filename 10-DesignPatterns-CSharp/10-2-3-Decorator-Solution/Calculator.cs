namespace Decorator
{
    using System;
    using System.Threading;

    public sealed class Calculator : ICalculator
    {
        public void Calculate()
        {
            // Simulate a long running operation by letting the thread sleep for some time
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Calculation completed");
        }
    }
}
