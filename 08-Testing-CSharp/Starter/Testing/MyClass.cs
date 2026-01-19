namespace Testing;

public sealed class MyClass
{
    public void DoLoop()
    {
        Console.WriteLine("Before loop");

        for (var i = 1; i <=3; i++)
        {
            Console.WriteLine($"In loop: {i}");
        }

        Console.WriteLine("After loop");
    }
}