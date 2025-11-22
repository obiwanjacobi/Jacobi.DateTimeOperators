namespace Jacobi.DateTimeOperators.Tests;

using Jacobi.DateTimeOperators;

public class TimeOnlyTest
{
    [Fact]
    public void AddMicroseconds()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt + 3.us;
        Assert.Equal(3, dt1.Microsecond);
    }
    [Fact]
    public void SubMicroseconds()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt - 3.us;
        Assert.Equal(997, dt1.Microsecond);
        Assert.Equal(999, dt1.Millisecond);
        Assert.Equal(33, dt1.Second);
        Assert.Equal(23, dt1.Minute);
        Assert.Equal(12, dt1.Hour);
    }
    [Fact]
    public void AddMicrosecondsF()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt + 3.5.us;
        Assert.Equal(500, dt1.Nanosecond);
        Assert.Equal(3, dt1.Microsecond);
    }
    [Fact]
    public void SubMicrosecondsF()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt - 3.5.us;
        Assert.Equal(500, dt1.Nanosecond);
        Assert.Equal(996, dt1.Microsecond);
        Assert.Equal(999, dt1.Millisecond);
        Assert.Equal(33, dt1.Second);
        Assert.Equal(23, dt1.Minute);
        Assert.Equal(12, dt1.Hour);
    }

    [Fact]
    public void AddMilliseconds()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt + 3.ms;
        Assert.Equal(3, dt1.Millisecond);
        Assert.Equal(34, dt1.Second);
        Assert.Equal(23, dt1.Minute);
        Assert.Equal(12, dt1.Hour);
    }
    [Fact]
    public void SubMilliseconds()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt - 3.ms;
        Assert.Equal(997, dt1.Millisecond);
        Assert.Equal(33, dt1.Second);
        Assert.Equal(23, dt1.Minute);
        Assert.Equal(12, dt1.Hour);
    }
    [Fact]
    public void AddMillisecondsF()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt + 3.5.ms;
        Assert.Equal(500, dt1.Microsecond);
        Assert.Equal(3, dt1.Millisecond);
    }
    [Fact]
    public void SubMillisecondsF()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt - 3.5.ms;
        Assert.Equal(500, dt1.Microsecond);
        Assert.Equal(996, dt1.Millisecond);
        Assert.Equal(33, dt1.Second);
        Assert.Equal(23, dt1.Minute);
        Assert.Equal(12, dt1.Hour);
    }

    [Fact]
    public void AddSeconds()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt + 3.s;
        Assert.Equal(37, dt1.Second);
    }
    [Fact]
    public void SubSeconds()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt - 3.s;
        Assert.Equal(31, dt1.Second);
        Assert.Equal(23, dt1.Minute);
        Assert.Equal(12, dt1.Hour);
    }
    [Fact]
    public void AddSecondsF()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt + 3.5.s;
        Assert.Equal(500, dt1.Millisecond);
        Assert.Equal(37, dt1.Second);
    }
    [Fact]
    public void SubSecondsF()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt - 3.5.s;
        Assert.Equal(500, dt1.Millisecond);
        Assert.Equal(30, dt1.Second);
        Assert.Equal(23, dt1.Minute);
        Assert.Equal(12, dt1.Hour);
    }

    [Fact]
    public void AddMinutes()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt + 3.m;
        Assert.Equal(26, dt1.Minute);
    }
    [Fact]
    public void SubMinutes()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt - 3.m;
        Assert.Equal(20, dt1.Minute);
        Assert.Equal(12, dt1.Hour);
    }
    [Fact]
    public void AddMinutesF()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt + 3.5.m;
        Assert.Equal(04, dt1.Second);
        Assert.Equal(27, dt1.Minute);
        Assert.Equal(12, dt1.Hour);
    }
    [Fact]
    public void SubMinutesF()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt - 3.5.m;
        Assert.Equal(4, dt1.Second);
        Assert.Equal(20, dt1.Minute);
        Assert.Equal(12, dt1.Hour);
    }

    [Fact]
    public void AddHours()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt + 3.h;
        Assert.Equal(15, dt1.Hour);
    }
    [Fact]
    public void SubHours()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt - 3.h;
        Assert.Equal(9, dt1.Hour);
    }
    [Fact]
    public void AddHoursF()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt + 3.5.h;
        Assert.Equal(53, dt1.Minute);
        Assert.Equal(15, dt1.Hour);
    }
    [Fact]
    public void SubHoursF()
    {
        var dt = new TimeOnly(12, 23, 34);
        var dt1 = dt - 3.5.h;
        Assert.Equal(53, dt1.Minute);
        Assert.Equal(8, dt1.Hour);
    }

    [Fact]
    public void FromHMS()
    {
        var hours = new Hours(13);
        var minutes = new Minutes(23);
        var seconds = new Seconds(42);
        var dt = TimeOnly.From(hours, minutes, seconds);
        Assert.Equal(new TimeOnly(13, 23, 42), dt);
    }
    [Fact]
    public void FromHMSmsus()
    {
        var hours = new Hours(13);
        var minutes = new Minutes(23);
        var seconds = new Seconds(42);
        var millis = new Milliseconds(432);
        var micros = new Microseconds(745);
        var dt = TimeOnly.From(hours, minutes, seconds, millis, micros);
        Assert.Equal(new TimeOnly(13, 23, 42, 432, 745), dt);
    }

    [Fact]
    public void ToHMS()
    {
        var dt = new TimeOnly(13, 23, 45);
        dt.To(out Hours hours, out Minutes minutes, out Seconds seconds);
        Assert.Equal(13, hours.Value);
        Assert.Equal(23, minutes.Value);
        Assert.Equal(45, seconds.Value);
    }
    [Fact]
    public void ToHMSmsus()
    {
        var dt = new TimeOnly(13, 23, 45, 345, 567);
        dt.To(out Hours hours, out Minutes minutes, out Seconds seconds, out Milliseconds milliseconds, out Microseconds microseconds);
        Assert.Equal(13, hours.Value);
        Assert.Equal(23, minutes.Value);
        Assert.Equal(45, seconds.Value);
        Assert.Equal(345, milliseconds.Value);
        Assert.Equal(567, microseconds.Value);
    }
}
