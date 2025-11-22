namespace Jacobi.DateTimeOperators;

public static class DateOnlyExtensions
{
    extension(DateOnly dateOnly)
    {
        public void To(out Years years, out Months months, out Days days)
        {
            years = new(dateOnly.Year);
            months = new(dateOnly.Month);
            days = new(dateOnly.Day);
        }
    }

    extension(DateOnly)
    {
        public static DateTime From(Years years, Months months, Days days)
            => new(years.Value, months.Value, days.Value);

        public static DateOnly operator +(DateOnly dateOnly, Days days)
            => dateOnly.AddDays(days.Value);
        public static DateOnly operator -(DateOnly dateOnly, Days days)
            => dateOnly.AddDays(-days.Value);

        public static DateOnly operator +(DateOnly dateOnly, Months months)
            => dateOnly.AddMonths(months.Value);
        public static DateOnly operator -(DateOnly dateOnly, Months months)
            => dateOnly.AddMonths(-months.Value);

        public static DateOnly operator +(DateOnly dateOnly, Years years)
            => dateOnly.AddYears(years.Value);
        public static DateOnly operator -(DateOnly dateOnly, Years years)
            => dateOnly.AddYears(-years.Value);
    }
}
