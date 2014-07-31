using Xunit;

namespace SeeingSharp.Tests
{
    public class WhosCallingTests
    {
        [Fact]
        public void Test()
        {
            var whosCalling = new WhosCalling();

            whosCalling.TraceMessage("foo");
        }
    }
}