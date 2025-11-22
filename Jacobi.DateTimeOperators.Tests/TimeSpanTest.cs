namespace Jacobi.DateTimeOperators.Tests;

using Jacobi.DateTimeOperators;

public class TimeSpanTest
{
    [Fact]
    public void AddMicroseconds()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt + 3.us;
        Assert.Equal(3, dt1.Microseconds);
    }
    [Fact]
    public void SubMicroseconds()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt - 3.us;
        Assert.Equal(997, dt1.Microseconds);
        Assert.Equal(999, dt1.Milliseconds);
        Assert.Equal(33, dt1.Seconds);
        Assert.Equal(23, dt1.Minutes);
        Assert.Equal(12, dt1.Hours);
    }
    [Fact]
    public void AddMicrosecondsF()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt + 3.5.us;
        Assert.Equal(500, dt1.Nanoseconds);
        Assert.Equal(3, dt1.Microseconds);
    }
    [Fact]
    public void SubMicrosecondsF()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt - 3.5.us;
        Assert.Equal(500, dt1.Nanoseconds);
        Assert.Equal(996, dt1.Microseconds);
        Assert.Equal(999, dt1.Milliseconds);
        Assert.Equal(33, dt1.Seconds);
        Assert.Equal(23, dt1.Minutes);
        Assert.Equal(12, dt1.Hours);
    }

    [Fact]
    public void AddMilliseconds()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt + 3.ms;
        Assert.Equal(3, dt1.Milliseconds);
        Assert.Equal(34, dt1.Seconds);
        Assert.Equal(23, dt1.Minutes);
        Assert.Equal(12, dt1.Hours);
    }
    [Fact]
    public void SubMilliseconds()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt - 3.ms;
        Assert.Equal(997, dt1.Milliseconds);
        Assert.Equal(33, dt1.Seconds);
        Assert.Equal(23, dt1.Minutes);
        Assert.Equal(12, dt1.Hours);
    }
    [Fact]
    public void AddMillisecondsF()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt + 3.5.ms;
        Assert.Equal(500, dt1.Microseconds);
        Assert.Equal(3, dt1.Milliseconds);
    }
    [Fact]
    public void SubMillisecondsF()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt - 3.5.ms;
        Assert.Equal(500, dt1.Microseconds);
        Assert.Equal(996, dt1.Milliseconds);
        Assert.Equal(33, dt1.Seconds);
        Assert.Equal(23, dt1.Minutes);
        Assert.Equal(12, dt1.Hours);
    }

    [Fact]
    public void AddSeconds()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt + 3.s;
        Assert.Equal(37, dt1.Seconds);
    }
    [Fact]
    public void SubSeconds()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt - 3.s;
        Assert.Equal(31, dt1.Seconds);
        Assert.Equal(23, dt1.Minutes);
        Assert.Equal(12, dt1.Hours);
    }
    [Fact]
    public void AddSecondsF()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt + 3.5.s;
        Assert.Equal(500, dt1.Milliseconds);
        Assert.Equal(37, dt1.Seconds);
    }
    [Fact]
    public void SubSecondsF()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt - 3.5.s;
        Assert.Equal(500, dt1.Milliseconds);
        Assert.Equal(30, dt1.Seconds);
        Assert.Equal(23, dt1.Minutes);
        Assert.Equal(12, dt1.Hours);
    }

    [Fact]
    public void AddMinutes()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt + 3.m;
        Assert.Equal(26, dt1.Minutes);
    }
    [Fact]
    public void SubMinutes()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt - 3.m;
        Assert.Equal(20, dt1.Minutes);
        Assert.Equal(12, dt1.Hours);
    }
    [Fact]
    public void AddMinutesF()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt + 3.5.m;
        Assert.Equal(04, dt1.Seconds);
        Assert.Equal(27, dt1.Minutes);
        Assert.Equal(12, dt1.Hours);
    }
    [Fact]
    public void SubMinutesF()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt - 3.5.m;
        Assert.Equal(4, dt1.Seconds);
        Assert.Equal(20, dt1.Minutes);
        Assert.Equal(12, dt1.Hours);
    }

    [Fact]
    public void AddHours()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt + 3.h;
        Assert.Equal(15, dt1.Hours);
    }
    [Fact]
    public void SubHours()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt - 3.h;
        Assert.Equal(9, dt1.Hours);
    }
    [Fact]
    public void AddHoursF()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt + 3.5.h;
        Assert.Equal(53, dt1.Minutes);
        Assert.Equal(15, dt1.Hours);
    }
    [Fact]
    public void SubHoursF()
    {
        var dt = new TimeSpan(12, 23, 34);
        var dt1 = dt - 3.5.h;
        Assert.Equal(53, dt1.Minutes);
        Assert.Equal(8, dt1.Hours);
    }

    [Fact]
    public void AddDays()
    {
        var dt = new TimeSpan(11, 15, 23, 45);
        var dt1 = dt + 3.d;
        Assert.Equal(45, dt1.Seconds);
        Assert.Equal(23, dt1.Minutes);
        Assert.Equal(15, dt1.Hours);
        Assert.Equal(14, dt1.Days);
    }
    [Fact]
    public void SubDays()
    {
        var dt = new TimeSpan(11, 15, 23, 45);
        var dt1 = dt - 3.d;
        Assert.Equal(45, dt1.Seconds);
        Assert.Equal(23, dt1.Minutes);
        Assert.Equal(15, dt1.Hours);
        Assert.Equal(8, dt1.Days);
    }
    [Fact]
    public void AddDaysF()
    {
        var dt = new TimeSpan(11, 15, 23, 45);
        var dt1 = dt + 3.5.d;
        Assert.Equal(45, dt1.Seconds);
        Assert.Equal(23, dt1.Minutes);
        Assert.Equal(3, dt1.Hours);
        Assert.Equal(15, dt1.Days);
    }
    [Fact]
    public void SubDaysF()
    {
        var dt = new TimeSpan(11, 15, 23, 45);
        var dt1 = dt - 3.5.d;
        Assert.Equal(45, dt1.Seconds);
        Assert.Equal(23, dt1.Minutes);
        Assert.Equal(3, dt1.Hours);
        Assert.Equal(8, dt1.Days);
    }

    [Fact]
    public void FromT()
    {
        var ticks = new Ticks(42211290812);
        var dt = TimeSpan.From(ticks);
        Assert.Equal(42211290812, dt.Ticks);
    }
    [Fact]
    public void FromHMS()
    {
        var hours = new Hours(13);
        var minutes = new Minutes(23);
        var seconds = new Seconds(42);
        var dt = TimeSpan.From(hours, minutes, seconds);
        Assert.Equal(new TimeSpan(13, 23, 42), dt);
    }
    [Fact]
    public void FromDHMS()
    {
        var days = new Days(3);
        var hours = new Hours(13);
        var minutes = new Minutes(23);
        var seconds = new Seconds(42);
        var dt = TimeSpan.From(days, hours, minutes, seconds);
        Assert.Equal(new TimeSpan(3, 13, 23, 42), dt);
    }
    [Fact]
    public void FromDHMSmsus()
    {
        var days = new Days(3);
        var hours = new Hours(13);
        var minutes = new Minutes(23);
        var seconds = new Seconds(42);
        var millis = new Milliseconds(432);
        var micros = new Microseconds(745);
        var dt = TimeSpan.From(days, hours, minutes, seconds, millis, micros);
        Assert.Equal(new TimeSpan(3, 13, 23, 42, 432, 745), dt);
    }

    [Fact]
    public void ToHMS()
    {
        var dt = new TimeSpan(13, 23, 45);
        dt.To(out Hours hours, out Minutes minutes, out Seconds seconds);
        Assert.Equal(13, hours.Value);
        Assert.Equal(23, minutes.Value);
        Assert.Equal(45, seconds.Value);
    }
    [Fact]
    public void ToDHMS()
    {
        var dt = new TimeSpan(15, 13, 23, 45);
        dt.To(out Days days, out Hours hours, out Minutes minutes, out Seconds seconds);
        Assert.Equal(15, days.Value);
        Assert.Equal(13, hours.Value);
        Assert.Equal(23, minutes.Value);
        Assert.Equal(45, seconds.Value);
    }
    [Fact]
    public void ToDHMSmsus()
    {
        var dt = new TimeSpan(15, 13, 23, 45, 345, 567);
        dt.To(out Days days, out Hours hours, out Minutes minutes, out Seconds seconds, out Milliseconds milliseconds, out Microseconds microseconds);
        Assert.Equal(15, days.Value);
        Assert.Equal(13, hours.Value);
        Assert.Equal(23, minutes.Value);
        Assert.Equal(45, seconds.Value);
        Assert.Equal(345, milliseconds.Value);
        Assert.Equal(567, microseconds.Value);
    }
}
