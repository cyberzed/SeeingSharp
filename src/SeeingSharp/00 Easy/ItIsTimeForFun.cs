using System;
using System.Diagnostics;

namespace SeeingSharp
{
    public class ItIsTimeForFun
    {
        public TimeSpan MightBeAccurate()
        {
            var start = DateTime.Now;

            //DO STUFF!!!

            var end = DateTime.Now;

            return end - start;
        }

        public TimeSpan EvenMoreAccurate()
        {
            var stp = Stopwatch.StartNew();

            //DO STUFF!!!

            stp.Stop();

            return stp.Elapsed;
        }
    }
}