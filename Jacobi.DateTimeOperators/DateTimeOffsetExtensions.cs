namespace Jacobi.DateTimeOperators;

public static class DateTimeOffsetExtensions
{
    public static void Deconstruct(this DateTimeOffset dateTime, out Years years, out Months months, out Days days, out Hours hours, out Minutes minutes, out Seconds seconds)
        => To(dateTime, out years, out months, out days, out hours, out minutes, out seconds);
    public static void Deconstruct(this DateTimeOffset dateTime, out Years years, out Months months, out Days days, out Hours hours, out Minutes minutes, out Seconds seconds, out Milliseconds milliseconds, out Microseconds microseconds)
        => To(dateTime, out years, out months, out days, out hours, out minutes, out seconds, out milliseconds, out microseconds);


    extension(DateTimeOffset dateTime)
    {
        public TimeSpan To(out Years years, out Months months, out Days days)
        {
            years = new(dateTime.Year);
            months = new(dateTime.Month);
            days = new(dateTime.Day);
            return dateTime.Offset;
        }

        public TimeSpan To(out Hours hours, out Minutes minutes, out Seconds seconds)
        {
            hours = new(dateTime.Hour);
            minutes = new(dateTime.Minute);
            seconds = new(dateTime.Second);
            return dateTime.Offset;
        }

        public TimeSpan To(out Years years, out Months months, out Days days, out Hours hours, out Minutes minutes, out Seconds seconds)
        {
            years = new(dateTime.Year);
            months = new(dateTime.Month);
            days = new(dateTime.Day);
            hours = new(dateTime.Hour);
            minutes = new(dateTime.Minute);
            seconds = new(dateTime.Second);
            return dateTime.Offset;
        }

        public TimeSpan To(out Years years, out Months months, out Days days, out Hours hours, out Minutes minutes, out Seconds seconds, out Milliseconds milliseconds, out Microseconds microseconds)
        {
            years = new(dateTime.Year);
            months = new(dateTime.Month);
            days = new(dateTime.Day);
            hours = new(dateTime.Hour);
            minutes = new(dateTime.Minute);
            seconds = new(dateTime.Second);
            milliseconds = new(dateTime.Millisecond);
            microseconds = new(dateTime.Microsecond);
            return dateTime.Offset;
        }
    }

    extension(DateTimeOffset)
    {
        public static DateTimeOffset From(Ticks ticks, TimeSpan offset)
            => new(ticks.Value, offset);
        public static DateTimeOffset From(Years years, Months months, Days days, TimeSpan offset)
            => new(years.Value, months.Value, days.Value, 0, 0, 0, offset);
        public static DateTimeOffset From(Years years, Months months, Days days, Hours hours, Minutes minutes, Seconds seconds, TimeSpan offset)
            => new(years.Value, months.Value, days.Value, hours.Value, minutes.IntValue, seconds.IntValue, offset);
        public static DateTimeOffset From(Years years, Months months, Days days, Hours hours, Minutes minutes, Seconds seconds, Milliseconds milliseconds, Microseconds microseconds, TimeSpan offset)
            => new(years.Value, months.Value, days.Value, hours.Value, minutes.IntValue, seconds.IntValue, milliseconds.IntValue, microseconds.IntValue, offset);

        public static DateTimeOffset operator +(DateTimeOffset dateTime, Ticks ticks)
            => dateTime.AddTicks(ticks.Value);
        public static DateTimeOffset operator -(DateTimeOffset dateTime, Ticks ticks)
            => dateTime.AddTicks(-ticks.Value);

        public static DateTimeOffset operator +(DateTimeOffset dateTime, TimeSpan timeSpan)
            => dateTime.Add(timeSpan);
        public static DateTimeOffset operator -(DateTimeOffset dateTime, TimeSpan timeSpan)
            => dateTime.Add(timeSpan.Negate());

        public static DateTimeOffset operator +(DateTimeOffset dateTime, Microseconds microseconds)
            => dateTime.AddMicroseconds(microseconds.Value);
        public static DateTimeOffset operator -(DateTimeOffset dateTime, Microseconds microseconds)
            => dateTime.AddMicroseconds(-microseconds.Value);

        public static DateTimeOffset operator +(DateTimeOffset dateTime, MicrosecondsF microseconds)
            => dateTime.AddMicroseconds(microseconds.Value);
        public static DateTimeOffset operator -(DateTimeOffset dateTime, MicrosecondsF microseconds)
            => dateTime.AddMicroseconds(-microseconds.Value);

        public static DateTimeOffset operator +(DateTimeOffset dateTime, Milliseconds milliseconds)
            => dateTime.AddMilliseconds(milliseconds.Value);
        public static DateTimeOffset operator -(DateTimeOffset dateTime, Milliseconds milliseconds)
            => dateTime.AddMilliseconds(-milliseconds.Value);

        public static DateTimeOffset operator +(DateTimeOffset dateTime, MillisecondsF milliseconds)
            => dateTime.AddMilliseconds(milliseconds.Value);
        public static DateTimeOffset operator -(DateTimeOffset dateTime, MillisecondsF milliseconds)
            => dateTime.AddMilliseconds(-milliseconds.Value);

        public static DateTimeOffset operator +(DateTimeOffset dateTime, Seconds seconds)
            => dateTime.AddSeconds(seconds.Value);
        public static DateTimeOffset operator -(DateTimeOffset dateTime, Seconds seconds)
            => dateTime.AddSeconds(-seconds.Value);

        public static DateTimeOffset operator +(DateTimeOffset dateTime, SecondsF seconds)
            => dateTime.AddSeconds(seconds.Value);
        public static DateTimeOffset operator -(DateTimeOffset dateTime, SecondsF seconds)
            => dateTime.AddSeconds(-seconds.Value);

        public static DateTimeOffset operator +(DateTimeOffset dateTime, Minutes minutes)
            => dateTime.AddMinutes(minutes.Value);
        public static DateTimeOffset operator -(DateTimeOffset dateTime, Minutes minutes)
            => dateTime.AddMinutes(-minutes.Value);

        public static DateTimeOffset operator +(DateTimeOffset dateTime, MinutesF minutes)
            => dateTime.AddMinutes(minutes.Value);
        public static DateTimeOffset operator -(DateTimeOffset dateTime, MinutesF minutes)
            => dateTime.AddMinutes(-minutes.Value);

        public static DateTimeOffset operator +(DateTimeOffset dateTime, Hours hours)
            => dateTime.AddHours(hours.Value);
        public static DateTimeOffset operator -(DateTimeOffset dateTime, Hours hours)
            => dateTime.AddHours(-hours.Value);

        public static DateTimeOffset operator +(DateTimeOffset dateTime, HoursF hours)
            => dateTime.AddHours(hours.Value);
        public static DateTimeOffset operator -(DateTimeOffset dateTime, HoursF hours)
            => dateTime.AddHours(-hours.Value);

        public static DateTimeOffset operator +(DateTimeOffset dateTime, Days days)
            => dateTime.AddDays(days.Value);
        public static DateTimeOffset operator -(DateTimeOffset dateTime, Days days)
            => dateTime.AddDays(-days.Value);

        public static DateTimeOffset operator +(DateTimeOffset dateTime, DaysF days)
            => dateTime.AddDays(days.Value);
        public static DateTimeOffset operator -(DateTimeOffset dateTime, DaysF days)
            => dateTime.AddDays(-days.Value);

        public static DateTimeOffset operator +(DateTimeOffset dateTime, Months months)
            => dateTime.AddMonths(months.Value);
        public static DateTimeOffset operator -(DateTimeOffset dateTime, Months months)
            => dateTime.AddMonths(-months.Value);

        public static DateTimeOffset operator +(DateTimeOffset dateTime, Years years)
            => dateTime.AddYears(years.Value);
        public static DateTimeOffset operator -(DateTimeOffset dateTime, Years years)
            => dateTime.AddYears(-years.Value);
    }
}
