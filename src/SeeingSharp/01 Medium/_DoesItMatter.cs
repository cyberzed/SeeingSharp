using System;
using System.Diagnostics;

namespace SeeingSharp
{
    public class DoesItMatter
    {
        public double DoesIt(DateTime dateTime)
        {
            LogInput(dateTime);

            return (dateTime - DateTime.Now).TotalDays;
        }

        [Conditional("DEBUG")]
        private void LogInput(DateTime dateTime)
        {
            Console.WriteLine(dateTime);
        }
    }
}