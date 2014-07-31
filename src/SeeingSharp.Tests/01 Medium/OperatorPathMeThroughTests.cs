using Xunit;

namespace SeeingSharp.Tests
{
    public class OperatorPathMeThroughTests
    {
        [Fact]
        public void Test()
        {
            var operatorPatchMeThrough = new OperatorPatchMeThrough(42);

            if (operatorPatchMeThrough)
            {
                Assert.True((bool) operatorPatchMeThrough);
            }
        }
    }
}