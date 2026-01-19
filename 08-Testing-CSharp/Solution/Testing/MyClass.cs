namespace Testing;

public sealed class MyClass(ILogger logger)
{
    public void DoLoop()
    {
        logger.Log("Before loop");

        for (var i = 1; i <=3; i++)
        {
            logger.Log($"In loop: {i}");
        }

        logger.Log("After loop");
    }
}