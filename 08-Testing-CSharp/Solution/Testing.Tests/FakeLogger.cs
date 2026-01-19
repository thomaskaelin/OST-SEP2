namespace Testing.Tests;

public sealed class FakeLogger : ILogger
{
    private readonly List<string> _loggedMessages = new();
    
    public void Log(string message) => _loggedMessages.Add(message);

    public IReadOnlyList<string> LoggedMessages => _loggedMessages.AsReadOnly();
}