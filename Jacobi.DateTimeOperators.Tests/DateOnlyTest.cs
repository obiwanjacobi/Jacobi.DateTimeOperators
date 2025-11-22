namespace Jacobi.DateTimeOperators.Tests;

using Jacobi.DateTimeOperators;

public class DateOnlyTest
{
    [Fact]
    public void AddDays()
    {
        var dt = new DateOnly(2025, 11, 15);
        var dt1 = dt + 3.d;
        Assert.Equal(18, dt1.Day);
    }
    [Fact]
    public void SubDays()
    {
        var dt = new DateOnly(2025, 11, 15);
        var dt1 = dt - 3.d;
        Assert.Equal(12, dt1.Day);
    }

    [Fact]
    public void AddMonths()
    {
        var dt = new DateOnly(2025, 8, 15);
        var dt1 = dt + 3.M;
        Assert.Equal(11, dt1.Month);
    }
    [Fact]
    public void SubMonths()
    {
        var dt = new DateOnly(2025, 11, 15);
        var dt1 = dt - 3.M;
        Assert.Equal(8, dt1.Month);
    }

    [Fact]
    public void AddYears()
    {
        var dt = new DateOnly(2025, 11, 15);
        var dt1 = dt + 3.y;
        Assert.Equal(2028, dt1.Year);
    }
    [Fact]
    public void SubYears()
    {
        var dt = new DateOnly(2025, 11, 15);
        var dt1 = dt - 3.y;
        Assert.Equal(2022, dt1.Year);
    }

    [Fact]
    public void FromYMD()
    {
        var years = new Years(2025);
        var months = new Months(11);
        var days = new Days(23);
        var dt = DateOnly.From(years, months, days);
        Assert.Equal(2025, dt.Year);
        Assert.Equal(11, dt.Month);
        Assert.Equal(23, dt.Day);
    }

    [Fact]
    public void ToYMD()
    {
        var dt = new DateOnly(2025, 11, 15);
        dt.To(out Years years, out Months months, out Days days);
        Assert.Equal(2025, years.Value);
        Assert.Equal(11, months.Value);
        Assert.Equal(15, days.Value);
    }
}
