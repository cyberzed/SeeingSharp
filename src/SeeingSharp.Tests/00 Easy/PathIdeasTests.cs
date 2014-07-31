using Xunit;

namespace SeeingSharp.Tests
{
    public class PathIdeasTests
    {
        [Fact]
        public void Test()
        {
            var pathIdeas = new PathIdeas();

            var badPathing = pathIdeas.BadPathing(@"c:\waste_of", "code");
            var awesomePathToHeaven = pathIdeas.AwesomePathToHeaven(@"c:\can_haz_your\", "babies");
        }
    }
}