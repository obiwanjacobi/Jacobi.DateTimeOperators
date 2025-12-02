namespace Jacobi.DateTimeOperators.Tests;

using Jacobi.DateTimeOperators;

public class DateTimeTest
{
    [Fact]
    public void AddTicks()
    {
        var dt = new DateTime(42211290812);
        var dt1 = dt + 3.t;
        Assert.Equal(42211290815, dt1.Ticks);
    }
    [Fact]
    public void SubTicks()
    {
        var dt = new DateTime(42211290812);
        var dt1 = dt - 3.t;
        Assert.Equal(42211290809, dt1.Ticks);
    }

    [Fact]
    public void AddMicroseconds()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt + 3.us;
        Assert.Equal(3, dt1.Microsecond);
    }
    [Fact]
    public void SubMicroseconds()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt - 3.us;
        Assert.Equal(997, dt1.Microsecond);
        Assert.Equal(999, dt1.Millisecond);
        Assert.Equal(59, dt1.Second);
        Assert.Equal(59, dt1.Minute);
        Assert.Equal(23, dt1.Hour);
        Assert.Equal(14, dt1.Day);
    }
    [Fact]
    public void AddMicrosecondsF()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt + 3.5.us;
        Assert.Equal(500, dt1.Nanosecond);
        Assert.Equal(3, dt1.Microsecond);
    }
    [Fact]
    public void SubMicrosecondsF()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt - 3.5.us;
        Assert.Equal(500, dt1.Nanosecond);
        Assert.Equal(996, dt1.Microsecond);
        Assert.Equal(999, dt1.Millisecond);
        Assert.Equal(59, dt1.Second);
        Assert.Equal(59, dt1.Minute);
        Assert.Equal(23, dt1.Hour);
        Assert.Equal(14, dt1.Day);
    }

    [Fact]
    public void AddMilliseconds()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt + 3.ms;
        Assert.Equal(3, dt1.Millisecond);
    }
    [Fact]
    public void SubMilliseconds()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt - 3.ms;
        Assert.Equal(997, dt1.Millisecond);
        Assert.Equal(59, dt1.Second);
        Assert.Equal(59, dt1.Minute);
        Assert.Equal(23, dt1.Hour);
        Assert.Equal(14, dt1.Day);
    }
    [Fact]
    public void AddMillisecondsF()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt + 3.5.ms;
        Assert.Equal(500, dt1.Microsecond);
        Assert.Equal(3, dt1.Millisecond);
    }
    [Fact]
    public void SubMillisecondsF()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt - 3.5.ms;
        Assert.Equal(500, dt1.Microsecond);
        Assert.Equal(996, dt1.Millisecond);
        Assert.Equal(59, dt1.Second);
        Assert.Equal(59, dt1.Minute);
        Assert.Equal(23, dt1.Hour);
        Assert.Equal(14, dt1.Day);
    }

    [Fact]
    public void AddSeconds()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt + 3.s;
        Assert.Equal(3, dt1.Second);
    }
    [Fact]
    public void SubSeconds()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt - 3.s;
        Assert.Equal(57, dt1.Second);
        Assert.Equal(59, dt1.Minute);
        Assert.Equal(23, dt1.Hour);
        Assert.Equal(14, dt1.Day);
    }
    [Fact]
    public void AddSecondsF()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt + 3.5.s;
        Assert.Equal(500, dt1.Millisecond);
        Assert.Equal(3, dt1.Second);
    }
    [Fact]
    public void SubSecondsF()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt - 3.5.s;
        Assert.Equal(500, dt1.Millisecond);
        Assert.Equal(56, dt1.Second);
        Assert.Equal(59, dt1.Minute);
        Assert.Equal(23, dt1.Hour);
        Assert.Equal(14, dt1.Day);
    }

    [Fact]
    public void AddMinutes()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt + 3.m;
        Assert.Equal(3, dt1.Minute);
    }
    [Fact]
    public void SubMinutes()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt - 3.m;
        Assert.Equal(57, dt1.Minute);
        Assert.Equal(23, dt1.Hour);
        Assert.Equal(14, dt1.Day);
    }
    [Fact]
    public void AddMinutesF()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt + 3.5.m;
        Assert.Equal(30, dt1.Second);
        Assert.Equal(3, dt1.Minute);
    }
    [Fact]
    public void SubMinutesF()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt - 3.5.m;
        Assert.Equal(30, dt1.Second);
        Assert.Equal(56, dt1.Minute);
        Assert.Equal(23, dt1.Hour);
        Assert.Equal(14, dt1.Day);
    }

    [Fact]
    public void AddHours()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt + 3.h;
        Assert.Equal(3, dt1.Hour);
    }
    [Fact]
    public void SubHours()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt - 3.h;
        Assert.Equal(21, dt1.Hour);
        Assert.Equal(14, dt1.Day);
    }
    [Fact]
    public void AddHoursF()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt + 3.5.h;
        Assert.Equal(30, dt1.Minute);
        Assert.Equal(3, dt1.Hour);
    }
    [Fact]
    public void SubHoursF()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt - 3.5.h;
        Assert.Equal(30, dt1.Minute);
        Assert.Equal(20, dt1.Hour);
        Assert.Equal(14, dt1.Day);
    }

    [Fact]
    public void AddDays()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt + 3.d;
        Assert.Equal(18, dt1.Day);
    }
    [Fact]
    public void SubDays()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt - 3.d;
        Assert.Equal(12, dt1.Day);
    }
    [Fact]
    public void AddDaysF()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt + 3.5.d;
        Assert.Equal(12, dt1.Hour);
        Assert.Equal(18, dt1.Day);
    }
    [Fact]
    public void SubDaysF()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt - 3.5.d;
        Assert.Equal(12, dt1.Hour);
        Assert.Equal(11, dt1.Day);
    }

    [Fact]
    public void AddMonths()
    {
        var dt = new DateTime(2025, 8, 15);
        var dt1 = dt + 3.M;
        Assert.Equal(11, dt1.Month);
    }
    [Fact]
    public void SubMonths()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt - 3.M;
        Assert.Equal(8, dt1.Month);
    }

    [Fact]
    public void AddYears()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt + 3.y;
        Assert.Equal(2028, dt1.Year);
    }
    [Fact]
    public void SubYears()
    {
        var dt = new DateTime(2025, 11, 15);
        var dt1 = dt - 3.y;
        Assert.Equal(2022, dt1.Year);
    }

    [Fact]
    public void FromT()
    {
        var ticks = new Ticks(42211290812);
        var dt = DateTime.From(ticks);
        Assert.Equal(42211290812, dt.Ticks);
    }
    [Fact]
    public void FromYMD()
    {
        var years = new Years(2025);
        var months = new Months(11);
        var days = new Days(23);
        var dt = DateTime.From(years, months, days);
        Assert.Equal(new DateTime(2025, 11, 23), dt);
    }
    [Fact]
    public void FromYMDHMS()
    {
        var years = new Years(2025);
        var months = new Months(11);
        var days = new Days(23);
        var hours = new Hours(13);
        var minutes = new Minutes(23);
        var seconds = new Seconds(42);
        var dt = DateTime.From(years, months, days, hours, minutes, seconds);
        Assert.Equal(new DateTime(2025, 11, 23, 13, 23, 42), dt);
    }
    [Fact]
    public void FromYMDHMSmsus()
    {
        var years = new Years(2025);
        var months = new Months(11);
        var days = new Days(23);
        var hours = new Hours(13);
        var minutes = new Minutes(23);
        var seconds = new Seconds(42);
        var millis = new Milliseconds(432);
        var micros = new Microseconds(745);
        var dt = DateTime.From(years, months, days, hours, minutes, seconds, millis, micros);
        Assert.Equal(new DateTime(2025, 11, 23, 13, 23, 42, 432, 745), dt);
    }

    [Fact]
    public void ToYMD()
    {
        var dt = new DateTime(2025, 11, 15);
        dt.To(out Years years, out Months months, out Days days);
        Assert.Equal(2025, years.Value);
        Assert.Equal(11, months.Value);
        Assert.Equal(15, days.Value);
    }
    [Fact]
    public void ToHMS()
    {
        var dt = new DateTime(2025, 11, 15, 13, 23, 45);
        dt.To(out Hours hours, out Minutes minutes, out Seconds seconds);
        Assert.Equal(13, hours.Value);
        Assert.Equal(23, minutes.Value);
        Assert.Equal(45, seconds.Value);
    }
    [Fact]
    public void ToYMDHMS()
    {
        var dt = new DateTime(2025, 11, 15, 13, 23, 45);
        dt.To(out Years years, out Months months, out Days days, out Hours hours, out Minutes minutes, out Seconds seconds);
        Assert.Equal(2025, years.Value);
        Assert.Equal(11, months.Value);
        Assert.Equal(15, days.Value);
        Assert.Equal(13, hours.Value);
        Assert.Equal(23, minutes.Value);
        Assert.Equal(45, seconds.Value);
    }
    [Fact]
    public void ToYMDHMSmsus()
    {
        var dt = new DateTime(2025, 11, 15, 13, 23, 45, 345, 567);
        dt.To(out Years years, out Months months, out Days days, out Hours hours, out Minutes minutes, out Seconds seconds, out Milliseconds milliseconds, out Microseconds microseconds);
        Assert.Equal(2025, years.Value);
        Assert.Equal(11, months.Value);
        Assert.Equal(15, days.Value);
        Assert.Equal(13, hours.Value);
        Assert.Equal(23, minutes.Value);
        Assert.Equal(45, seconds.Value);
        Assert.Equal(345, milliseconds.Value);
        Assert.Equal(567, microseconds.Value);
    }

    [Fact]
    public void DeconstructYMDHMS()
    {
        var dt = new DateTime(2025, 11, 15, 13, 23, 45);
        (Years years, Months months, Days days, Hours hours, Minutes minutes, Seconds seconds) = dt;
        Assert.Equal(2025, years.Value);
        Assert.Equal(11, months.Value);
        Assert.Equal(15, days.Value);
        Assert.Equal(13, hours.Value);
        Assert.Equal(23, minutes.Value);
        Assert.Equal(45, seconds.Value);
    }
    [Fact]
    public void DeconstructYMDHMSmsus()
    {
        var dt = new DateTime(2025, 11, 15, 13, 23, 45, 345, 567);
        (Years years, Months months, Days days, Hours hours, Minutes minutes, Seconds seconds, Milliseconds milliseconds, Microseconds microseconds) = dt;
        Assert.Equal(2025, years.Value);
        Assert.Equal(11, months.Value);
        Assert.Equal(15, days.Value);
        Assert.Equal(13, hours.Value);
        Assert.Equal(23, minutes.Value);
        Assert.Equal(45, seconds.Value);
        Assert.Equal(345, milliseconds.Value);
        Assert.Equal(567, microseconds.Value);
    }
}
