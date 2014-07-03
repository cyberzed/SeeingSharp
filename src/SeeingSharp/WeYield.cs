using System;
using System.Collections.Generic;

namespace SeeingSharp
{
    public class WeYield
    {
        public IEnumerable<int> RandomStuff
        {
            get
            {
                var rand = new Random();

                for (var i = 0; i < 10; i++)
                {
                    yield return rand.Next(0, 1001);
                }
            }
        }
    }

}