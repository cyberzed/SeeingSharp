using System;
using Xunit;

namespace SeeingSharp.Tests
{
    public class IsThisAUnionTests
    {
        [Fact]
        public void Test()
        {
            var isThisAUnion = new IsThisAUnion {UInt32 = uint.MaxValue};

            Assert.Equal(uint.MaxValue, isThisAUnion.UInt32);
            Console.WriteLine(isThisAUnion.UInt32);
            //Console.WriteLine("{0:X} {1:X} {2:X} {3:X}", isThisAUnion.One, isThisAUnion.Two, isThisAUnion.Three, isThisAUnion.Four);

            isThisAUnion.Four = 0;
            isThisAUnion.Three = 0;

            Assert.NotEqual(uint.MaxValue, isThisAUnion.UInt32);
            Console.WriteLine(isThisAUnion.UInt32);
            //Console.WriteLine("{0:X} {1:X} {2:X} {3:X}", isThisAUnion.One, isThisAUnion.Two, isThisAUnion.Three, isThisAUnion.Four);
        }
    }
}