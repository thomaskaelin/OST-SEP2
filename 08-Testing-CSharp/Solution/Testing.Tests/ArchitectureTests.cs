namespace Testing.Tests;

using ArchUnitNET.Loader;
using ArchUnitNET.xUnit;

using static ArchUnitNET.Fluent.ArchRuleDefinition;

public class ArchitectureTests
{
    [Fact]
    public void TypesInProductiveCode_MustNotDirectlyAccessSystemConsole()
    {
        var productiveCodeAssembly = typeof(MyClass).Assembly;
        var systemConsoleAssembly = typeof(System.Console).Assembly;

        var rule = Types()
            .That()
            .ResideInAssembly(productiveCodeAssembly)
            .And()
            .DoNotHaveName(nameof(ConsoleLogger))
            .Should()
            .NotDependOnAny(Types().That().ResideInAssembly(systemConsoleAssembly));

        var architecture = new ArchLoader()
            .LoadAssemblies(productiveCodeAssembly, systemConsoleAssembly)
            .Build();

        rule.Check(architecture);
    }

    [Fact]
    public void TestDoublesInTestCode_MustHavePrefixFakeInClassName()
    {
        var productiveCodeAssembly = typeof(MyClass).Assembly;
        var testCodeAssembly = typeof(ArchitectureTests).Assembly;

        var rule = Types()
            .That()
            .ResideInAssembly(testCodeAssembly)
            .And()
            .ImplementAnyInterfaces(Interfaces().That().ResideInAssembly(productiveCodeAssembly))
            .Should()
            .HaveNameStartingWith("Fake");

        var architecture = new ArchLoader()
            .LoadAssemblies(productiveCodeAssembly, testCodeAssembly)
            .Build();

        rule.Check(architecture);
    }
}