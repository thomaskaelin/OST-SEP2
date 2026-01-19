namespace Testing;

public sealed class ConsoleLogger : ILogger
{
    public void Log(string message) => System.Console.WriteLine(message);
}