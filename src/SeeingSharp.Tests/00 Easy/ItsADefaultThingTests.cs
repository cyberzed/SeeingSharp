using System;
using Xunit;

namespace SeeingSharp.Tests
{
    public class ItsADefaultThingTests
    {
        [Fact]
        public void Test()
        {
            var itsADefaultThing = new ItsADefaultThing();

            var zero = itsADefaultThing.Zero;

            Assert.Equal(0, zero);

            var nothing = itsADefaultThing.Nothing;

            Assert.Null(nothing);

            var something = itsADefaultThing.Something;

            Assert.Equal((ConsoleKey) 0, something);
        }
    }
}