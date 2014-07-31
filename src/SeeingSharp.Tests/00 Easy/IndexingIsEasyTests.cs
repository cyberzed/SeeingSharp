using Xunit;

namespace SeeingSharp.Tests
{
    public class IndexingIsEasyTests
    {
        [Fact]
        public void Test()
        {
            var foo = new IndexingIsEasy();

            var bar = foo[1];

            Assert.Equal("One", bar);
        }

        [Fact]
        public void MoarTest()
        {
            var foo = new IndexingIsEasy();

            var magicNumbers = new[] {4, 2};

            var bar = foo[magicNumbers];

            var expected = new[] {"Four", "Two"};

            Assert.Equal(expected, bar);
        }
    }
}