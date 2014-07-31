using Xunit;

namespace SeeingSharp.Tests
{
    public class ShowInDebugTests
    {
        [Fact]
        public void Test()
        {
            var badIdea = new ShowInDebug.BadIdea();

            var goodIdea = new ShowInDebug.GoodIdea();
        }
    }
}