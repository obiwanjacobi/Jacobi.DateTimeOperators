namespace Jacobi.DateTimeOperators;

public static class DateTimeExtensions
{
    extension(DateTime dateTime)
    {
        public void To(out Years years, out Months months, out Days days)
        {
            years = new(dateTime.Year);
            months = new(dateTime.Month);
            days = new(dateTime.Day);
        }

        public void To(out Hours hours, out Minutes minutes, out Seconds seconds)
        {
            hours = new(dateTime.Hour);
            minutes = new(dateTime.Minute);
            seconds = new(dateTime.Second);
        }

        public void To(out Years years, out Months months, out Days days, out Hours hours, out Minutes minutes, out Seconds seconds)
        {
            years = new(dateTime.Year);
            months = new(dateTime.Month);
            days = new(dateTime.Day);
            hours = new(dateTime.Hour);
            minutes = new(dateTime.Minute);
            seconds = new(dateTime.Second);
        }

        public void To(out Years years, out Months months, out Days days, out Hours hours, out Minutes minutes, out Seconds seconds, out Milliseconds milliseconds, out Microseconds microseconds)
        {
            years = new(dateTime.Year);
            months = new(dateTime.Month);
            days = new(dateTime.Day);
            hours = new(dateTime.Hour);
            minutes = new(dateTime.Minute);
            seconds = new(dateTime.Second);
            milliseconds = new(dateTime.Millisecond);
            microseconds = new(dateTime.Microsecond);
        }
    }

    extension(DateTime)
    {
        public static DateTime From(Ticks ticks)
            => new(ticks.Value);
        public static DateTime From(Years years, Months months, Days days)
            => new(years.Value, months.Value, days.Value);
        public static DateTime From(Years years, Months months, Days days, Hours hours, Minutes minutes, Seconds seconds)
            => new(years.Value, months.Value, days.Value, hours.Value, minutes.IntValue, seconds.IntValue);
        public static DateTime From(Years years, Months months, Days days, Hours hours, Minutes minutes, Seconds seconds, Milliseconds milliseconds, Microseconds microseconds)
            => new(years.Value, months.Value, days.Value, hours.Value, minutes.IntValue, seconds.IntValue, milliseconds.IntValue, microseconds.IntValue);

        public static DateTime operator +(DateTime dateTime, Ticks ticks)
            => dateTime.AddTicks(ticks.Value);
        public static DateTime operator -(DateTime dateTime, Ticks ticks)
            => dateTime.AddTicks(-ticks.Value);

        public static DateTime operator +(DateTime dateTime, TimeSpan timeSpan)
            => dateTime.Add(timeSpan);
        public static DateTime operator -(DateTime dateTime, TimeSpan timeSpan)
            => dateTime.Add(timeSpan.Negate());

        public static DateTime operator +(DateTime dateTime, Microseconds microseconds)
            => dateTime.AddMicroseconds(microseconds.Value);
        public static DateTime operator -(DateTime dateTime, Microseconds microseconds)
            => dateTime.AddMicroseconds(-microseconds.Value);

        public static DateTime operator +(DateTime dateTime, MicrosecondsF microseconds)
            => dateTime.AddMicroseconds(microseconds.Value);
        public static DateTime operator -(DateTime dateTime, MicrosecondsF microseconds)
            => dateTime.AddMicroseconds(-microseconds.Value);

        public static DateTime operator +(DateTime dateTime, Milliseconds milliseconds)
            => dateTime.AddMilliseconds(milliseconds.Value);
        public static DateTime operator -(DateTime dateTime, Milliseconds milliseconds)
            => dateTime.AddMilliseconds(-milliseconds.Value);

        public static DateTime operator +(DateTime dateTime, MillisecondsF milliseconds)
            => dateTime.AddMilliseconds(milliseconds.Value);
        public static DateTime operator -(DateTime dateTime, MillisecondsF milliseconds)
            => dateTime.AddMilliseconds(-milliseconds.Value);

        public static DateTime operator +(DateTime dateTime, Seconds seconds)
            => dateTime.AddSeconds(seconds.Value);
        public static DateTime operator -(DateTime dateTime, Seconds seconds)
            => dateTime.AddSeconds(-seconds.Value);

        public static DateTime operator +(DateTime dateTime, SecondsF seconds)
            => dateTime.AddSeconds(seconds.Value);
        public static DateTime operator -(DateTime dateTime, SecondsF seconds)
            => dateTime.AddSeconds(-seconds.Value);

        public static DateTime operator +(DateTime dateTime, Minutes minutes)
            => dateTime.AddMinutes(minutes.Value);
        public static DateTime operator -(DateTime dateTime, Minutes minutes)
            => dateTime.AddMinutes(-minutes.Value);

        public static DateTime operator +(DateTime dateTime, MinutesF minutes)
            => dateTime.AddMinutes(minutes.Value);
        public static DateTime operator -(DateTime dateTime, MinutesF minutes)
            => dateTime.AddMinutes(-minutes.Value);

        public static DateTime operator +(DateTime dateTime, Hours hours)
            => dateTime.AddHours(hours.Value);
        public static DateTime operator -(DateTime dateTime, Hours hours)
            => dateTime.AddHours(-hours.Value);

        public static DateTime operator +(DateTime dateTime, HoursF hours)
            => dateTime.AddHours(hours.Value);
        public static DateTime operator -(DateTime dateTime, HoursF hours)
            => dateTime.AddHours(-hours.Value);

        public static DateTime operator +(DateTime dateTime, Days days)
            => dateTime.AddDays(days.Value);
        public static DateTime operator -(DateTime dateTime, Days days)
            => dateTime.AddDays(-days.Value);

        public static DateTime operator +(DateTime dateTime, DaysF days)
            => dateTime.AddDays(days.Value);
        public static DateTime operator -(DateTime dateTime, DaysF days)
            => dateTime.AddDays(-days.Value);

        public static DateTime operator +(DateTime dateTime, Months months)
            => dateTime.AddMonths(months.Value);
        public static DateTime operator -(DateTime dateTime, Months months)
            => dateTime.AddMonths(-months.Value);

        public static DateTime operator +(DateTime dateTime, Years years)
            => dateTime.AddYears(years.Value);
        public static DateTime operator -(DateTime dateTime, Years years)
            => dateTime.AddYears(-years.Value);
    }
}
