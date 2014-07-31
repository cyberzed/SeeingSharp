using System.Linq;
using Xunit;

namespace SeeingSharp.Tests
{
    public class WeYieldTests
    {
        [Fact]
        public void Test()
        {
            var weYield = new WeYield();

            var randomStuff = weYield.RandomStuff;

            const int expected = 10;
            Assert.Equal(expected, randomStuff.Count());
        }
    }
}