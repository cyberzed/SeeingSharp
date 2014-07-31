using Xunit;

namespace SeeingSharp.Tests
{
    public class ReallyStupidIdeaTests
    {
        [Fact]
        public void Test()
        {
            var reallyStupidIdea = new ReallyStupidIdea();

            reallyStupidIdea.@event += (annoying, idea) => { };

            const int veryAnnoying = -42;
            reallyStupidIdea.@int = veryAnnoying;
        }
    }
}