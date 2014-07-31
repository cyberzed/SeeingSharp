using System.Collections.Generic;
using Xunit;

namespace SeeingSharp.Tests
{
    public class WhereIsItGenericTests
    {
        [Fact]
        public void Test()
        {
            //new WhereIsItGeneric<string>();
            //new WhereIsItGeneric<int>();
            new WhereIsItGeneric<List<string>>();
        }
    }
}