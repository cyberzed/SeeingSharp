using Xunit;

namespace SeeingSharp.Tests
{
    public class IAmImmutableTests
    {
        [Fact]
        public void Test()
        {
            var yesIAm = new IAmImmutable(42, "foo");
        }
    }
}