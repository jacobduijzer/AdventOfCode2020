using Xunit.Abstractions;

namespace AdventOfCode.Tests
{
    public class TestBase
    {
        protected readonly TestLogger TestLogger;

        protected TestBase(ITestOutputHelper testOutputHelper) =>
            TestLogger = new TestLogger(testOutputHelper);
    }
}