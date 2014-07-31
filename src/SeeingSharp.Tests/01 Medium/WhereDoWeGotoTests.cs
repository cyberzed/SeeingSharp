using Xunit;

namespace SeeingSharp.Tests
{
    public class WhereDoWeGotoTests
    {
        [Fact]
        public void Test()
        {
            var haveFun = WhereDoWeGoto.HaveFun(0);

            const int expected = 10;

            Assert.Equal(expected, haveFun);
        }

        [Fact]
        public void MoarTest()
        {
            var haveFun = WhereDoWeGoto.HaveFun(41);

            const int expected = 51;

            Assert.Equal(expected, haveFun);
        }
    }
}