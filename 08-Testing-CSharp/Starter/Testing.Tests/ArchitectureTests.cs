namespace Testing.Tests;

using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using ArchUnitNET.Fluent;
using ArchUnitNET.xUnit;

using static ArchUnitNET.Fluent.ArchRuleDefinition;

public class ArchitectureTests
{
    [Fact]
    public void TypesInProductiveCode_MustNotDirectlyAccessSystemConsole()
    {
        Assert.Fail("Exercise 2: Verify that types in productive code do not access Console.WriteLine()");
    }

    [Fact]
    public void TestDoublesInTestCode_MustHavePrefixFakeInClassName()
    {
        Assert.Fail("Exercise 2: Verify that test doubles defined in test code have the prefix Fake in the class name");
    }
}