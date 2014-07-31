using System;

namespace SeeingSharp
{
    public enum Duration
    {
        Day,
        Week,
        Month
    }

    public static class DurationExtention
    {
        public static DateTime From(this Duration duration, DateTime dateTime)
        {
            switch (duration)
            {
                case Duration.Day:
                    return dateTime.AddDays(1);
                case Duration.Week:
                    return dateTime.AddDays(7);
                case Duration.Month:
                    return dateTime.AddMonths(1);
                default:
                    throw new ArgumentOutOfRangeException("duration");
            }
        }
    }
}