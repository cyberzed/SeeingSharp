using System;
using Xunit;

namespace SeeingSharp.Tests
{
    public class ExtraLengthOnTheArmTests
    {
        [Fact]
        public void Test()
        {
            var duration = Duration.Week;

            var aWeekLater = duration.From(DateTime.Now);
        }
    }
}