using Xunit;

namespace SeeingSharp.Tests
{
    public class CheckItOutTests
    {
        [Fact]
        public void Test()
        {
            var checkItOut = new CheckItOut();

            var defaultWay = checkItOut.DefaultWay();
            var thatIsSoUnchecked = checkItOut.ThatIsSoUnchecked();
            var thatIsSoChecked = checkItOut.ThatIsSoChecked();
        }
    }
}