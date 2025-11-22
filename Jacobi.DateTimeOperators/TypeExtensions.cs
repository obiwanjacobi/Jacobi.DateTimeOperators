namespace Jacobi.DateTimeOperators;

public static class TypeExtensions
{
    extension(long value)
    {
        public Ticks t
            => new(value);
        public Ticks Ticks
            => new(value);

        public Microseconds us
            => new(value);
        public Microseconds Microseconds
            => new(value);

        public Milliseconds ms
            => new(value);
        public Milliseconds Milliseconds
            => new(value);

        public Seconds s
            => new(value);
        public Seconds Seconds
            => new(value);

        public Minutes m
            => new(value);
        public Minutes Minutes
            => new(value);
    }

    extension(int value)
    {
        public Ticks t
            => new(value);
        public Ticks Ticks
            => new(value);

        public Microseconds us
            => new(value);
        public Microseconds Microseconds
            => new(value);

        public Milliseconds ms
            => new(value);
        public Milliseconds Milliseconds
            => new(value);

        public Seconds s
            => new(value);
        public Seconds Seconds
            => new(value);

        public Minutes m
            => new(value);
        public Minutes Minutes
            => new(value);

        public Hours h
            => new(value);
        public Hours Hours
            => new(value);

        public Days d
            => new(value);
        public Days Days
            => new(value);

        public Months M
            => new(value);
        public Months Months
            => new(value);

        public Years y
            => new(value);
        public Years Years
            => new(value);
    }

    extension(double value)
    {
        public MicrosecondsF us
            => new(value);
        public MicrosecondsF Microseconds
            => new(value);

        public MillisecondsF ms
            => new(value);
        public MillisecondsF Milliseconds
            => new(value);

        public SecondsF s
            => new(value);
        public SecondsF Seconds
            => new(value);

        public MinutesF m
            => new(value);
        public MinutesF Minutes
            => new(value);

        public HoursF h
            => new(value);
        public HoursF Hours
            => new(value);

        public DaysF d
            => new(value);
        public DaysF Days
            => new(value);
    }
}
