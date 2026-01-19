namespace Testing;

public static class Program
{
    public static void Main(string[] args)
    {
        var consoleLogger = new ConsoleLogger();
        var myClass = new MyClass(consoleLogger);
        myClass.DoLoop();
    }
}