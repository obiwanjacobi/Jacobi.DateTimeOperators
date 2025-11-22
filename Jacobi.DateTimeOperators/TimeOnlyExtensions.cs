namespace Jacobi.DateTimeOperators;

public static class TimeOnlyExtensions
{
    extension(TimeOnly timeOnly)
    {
        public void To(out Hours hours, out Minutes minutes, out Seconds seconds)
        {
            hours = new(timeOnly.Hour);
            minutes = new(timeOnly.Minute);
            seconds = new(timeOnly.Second);
        }

        public void To(out Hours hours, out Minutes minutes, out Seconds seconds, out Milliseconds milliseconds)
        {
            hours = new(timeOnly.Hour);
            minutes = new(timeOnly.Minute);
            seconds = new(timeOnly.Second);
            milliseconds = new(timeOnly.Millisecond);
        }

        public void To(out Hours hours, out Minutes minutes, out Seconds seconds, out Milliseconds milliseconds, out Microseconds microseconds)
        {
            hours = new(timeOnly.Hour);
            minutes = new(timeOnly.Minute);
            seconds = new(timeOnly.Second);
            milliseconds = new(timeOnly.Millisecond);
            microseconds = new(timeOnly.Microsecond);
        }
    }

    extension(TimeOnly)
    {
        public static TimeOnly From(Hours hours, Minutes minutes, Seconds seconds)
            => new(hours.Value, minutes.IntValue, seconds.IntValue);
        public static TimeOnly From(Hours hours, Minutes minutes, Seconds seconds, Milliseconds milliseconds, Microseconds microseconds)
            => new(hours.Value, minutes.IntValue, seconds.IntValue, milliseconds.IntValue, microseconds.IntValue);

        public static TimeOnly operator +(TimeOnly TimeOnly, TimeSpan timeSpan)
            => TimeOnly.Add(timeSpan);
        public static TimeOnly operator -(TimeOnly TimeOnly, TimeSpan timeSpan)
            => TimeOnly.Add(timeSpan.Negate());

        public static TimeOnly operator +(TimeOnly timeOnly, Minutes minutes)
            => timeOnly.AddMinutes(minutes.Value);
        public static TimeOnly operator -(TimeOnly timeOnly, Minutes minutes)
            => timeOnly.AddMinutes(-minutes.Value);

        public static TimeOnly operator +(TimeOnly timeOnly, Hours hours)
            => timeOnly.AddHours(hours.Value);
        public static TimeOnly operator -(TimeOnly timeOnly, Hours hours)
            => timeOnly.AddHours(-hours.Value);
    }
}
