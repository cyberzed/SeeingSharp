using Xunit;

namespace SeeingSharp.Tests
{
    public class TouchingPrivatesTests
    {
        [Fact]
        public void Test()
        {
            var touchingPrivates = new TouchingPrivates();

            //touchingPrivates.Unwritable = 42;

            TouchingPrivates.Overwrite(touchingPrivates);
        }
    }
}