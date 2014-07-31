using System;
using Xunit;

namespace SeeingSharp.Tests
{
    public class WhatIsItTests
    {
        [Fact]
        public void Test()
        {
            var whatIsIt = new WhatIsIt();

            whatIsIt.IsItWhatYouThink("Test");
            whatIsIt.IsItWhatYouThink(4);
            whatIsIt.IsItWhatYouThink(ConsoleKey.S);

            whatIsIt.AsItShouldBe(42);
            whatIsIt.AsItShouldBe("Test");
        }
    }
}