using Xunit;

namespace SeeingSharp.Tests
{
    public class OrdnungMustSeinTests
    {
        [Fact]
        public void Test()
        {
            Assert.Equal(OrdnungMustSein.v1, OrdnungMustSein.v2);

            Assert.NotEqual(OrdnungMustSein.v3, OrdnungMustSein.v4);
        }
    }
}