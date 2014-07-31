using Xunit;

namespace SeeingSharp.Tests
{
    public class ItIsGenericNoMatterWhatTests
    {
        [Fact]
        public void Test()
        {
            // ReSharper disable once RedundantTypeArgumentsOfMethod
            ItIsGenericNoMatterWhat.YesItIs<int>(23);

            ItIsGenericNoMatterWhat.YesItIs(23);
        }
    }
}