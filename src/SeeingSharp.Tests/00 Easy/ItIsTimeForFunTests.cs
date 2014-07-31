using Xunit;

namespace SeeingSharp.Tests
{
    public class ItIsTimeForFunTests
    {
        [Fact]
        public void Test()
        {
            var forFun = new ItIsTimeForFun();

            var mightBeAccurate = forFun.MightBeAccurate();
            var evenMoreAccurate = forFun.EvenMoreAccurate();
        }
    }
}