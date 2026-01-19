namespace Testing.Tests;

using FluentAssertions;

public class MyClassTests
{
    private readonly MyClass _testee;
    private readonly FakeLogger _fakeLogger;

    public MyClassTests()
    {
        _fakeLogger = new FakeLogger();
        _testee = new MyClass(_fakeLogger);
    }

    [Fact]
    public void DoLoop_LogsMessages()
    {
        _testee.DoLoop();

        _fakeLogger.LoggedMessages.Should().BeEquivalentTo(
            "Before loop",
            "In loop: 1",
            "In loop: 2",
            "In loop: 3",
            "After loop");
    }
}