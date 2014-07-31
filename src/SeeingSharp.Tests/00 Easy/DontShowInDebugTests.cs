using Xunit;

namespace SeeingSharp.Tests
{
    public class DontShowInDebugTests
    {
        [Fact]
        public void Test()
        {
            var inDebug = new DontShowInDebug();

            inDebug.NotSoImportant();

            inDebug.Important();
        }
    }
}