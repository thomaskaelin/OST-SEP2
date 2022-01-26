namespace GildedRose
{
    using System;
    using System.IO;
    using System.Text;
    using ApprovalTests;
    using ApprovalTests.Reporters;
    using Xunit;

    [UseReporter(typeof(DiffReporter))]
    public class ApprovalTest
    {
        [Fact]
        public void ThirtyDays()
        {
            var consoleOutput = new StringBuilder();

            Console.SetOut(new StringWriter(consoleOutput));
            Console.SetIn(new StringReader(string.Empty));

            Program.Main(new string[] { });
            var output = consoleOutput.ToString();

            Approvals.Verify(output);
        }
    }
}
