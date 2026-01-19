namespace Testing.Tests;

public class MyClassTests
{
    private readonly MyClass _testee;

    public MyClassTests()
    {
        _testee = new MyClass();
    }

    [Fact]
    public void DoLoop_LogsMessages()
    {
        _testee.DoLoop();
        
        Assert.Fail("Exercise 1: Verify all messages logged by MyClass.DoLoop()");
    }
}