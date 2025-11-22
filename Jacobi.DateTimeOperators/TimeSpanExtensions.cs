namespace Jacobi.DateTimeOperators;

public static class TimeSpanExtensions
{
    extension(TimeSpan timeSpan)
    {
        public void To(out Hours hours, out Minutes minutes, out Seconds seconds)
        {
            hours = new(timeSpan.Hours);
            minutes = new(timeSpan.Minutes);
            seconds = new(timeSpan.Seconds);
        }

        public void To(out Days days, out Hours hours, out Minutes minutes, out Seconds seconds)
        {
            days = new(timeSpan.Days);
            hours = new(timeSpan.Hours);
            minutes = new(timeSpan.Minutes);
            seconds = new(timeSpan.Seconds);
        }

        public void To(out Hours hours, out Minutes minutes, out Seconds seconds, out Milliseconds milliseconds)
        {
            hours = new(timeSpan.Hours);
            minutes = new(timeSpan.Minutes);
            seconds = new(timeSpan.Seconds);
            milliseconds = new(timeSpan.Milliseconds);
        }

        public void To(out Days days, out Hours hours, out Minutes minutes, out Seconds seconds, out Milliseconds milliseconds, out Microseconds microseconds)
        {
            days = new(timeSpan.Days);
            hours = new(timeSpan.Hours);
            minutes = new(timeSpan.Minutes);
            seconds = new(timeSpan.Seconds);
            milliseconds = new(timeSpan.Milliseconds);
            microseconds = new(timeSpan.Microseconds);
        }
    }

    extension(TimeSpan)
    {
        public static TimeSpan From(Ticks ticks)
            => new(ticks.Value);
        public static TimeSpan From(Hours hours, Minutes minutes, Seconds seconds)
            => new(hours.Value, minutes.IntValue, seconds.IntValue);
        public static TimeSpan From(Days days, Hours hours, Minutes minutes, Seconds seconds)
            => new(days.Value, hours.Value, minutes.IntValue, seconds.IntValue);
        public static TimeSpan From(Days days, Hours hours, Minutes minutes, Seconds seconds, Milliseconds milliseconds, Microseconds microseconds)
            => new(days.Value, hours.Value, minutes.IntValue, seconds.IntValue, milliseconds.IntValue, microseconds.IntValue);
    }
}
