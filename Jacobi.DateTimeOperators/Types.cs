namespace Jacobi.DateTimeOperators;

// 100 nano-seconds per tick
public readonly record struct Ticks(long Value)
{
    //public static implicit operator long(Ticks ticks)
    //    => ticks.Value;
    //public static implicit operator Ticks(long ticks)
    //    => new(ticks);
}

public readonly record struct Microseconds(long Value)
{
    public static implicit operator TimeSpan(Microseconds us)
        => TimeSpan.FromMicroseconds(us.Value);

    public int IntValue => checked((int)Value);

    //public static implicit operator long(Microseconds us)
    //    => us.Value;
    //public static implicit operator Microseconds(long us)
    //    => new(us);
}
public readonly record struct MicrosecondsF(double Value)
{
    public static implicit operator TimeSpan(MicrosecondsF us)
        => TimeSpan.FromMicroseconds(us.Value);

    //public static implicit operator double(MicrosecondsF us)
    //    => us.Value;
    //public static implicit operator MicrosecondsF(double us)
    //    => new(us);
}

public readonly record struct Milliseconds(long Value)
{
    public static implicit operator TimeSpan(Milliseconds ms)
        => TimeSpan.FromMilliseconds(ms.Value);

    public static implicit operator Microseconds(Milliseconds ms)
        => new(ms.Value * 1000);

    public int IntValue => checked((int)Value);

    //public static implicit operator long(Milliseconds ms)
    //    => ms.Value;
    //public static implicit operator Milliseconds(long ms)
    //    => new(ms);
}
public readonly record struct MillisecondsF(double Value)
{
    public static implicit operator TimeSpan(MillisecondsF ms)
        => TimeSpan.FromMilliseconds(ms.Value);

    public static implicit operator MicrosecondsF(MillisecondsF ms)
        => new(ms.Value * 1000);

    //public static implicit operator double(MillisecondsF ms)
    //    => ms.Value;
    //public static implicit operator MillisecondsF(double ms)
    //    => new(ms);
}

public readonly record struct Seconds(long Value)
{
    public static implicit operator TimeSpan(Seconds s)
        => TimeSpan.FromSeconds(s.Value);

    public static implicit operator Milliseconds(Seconds s)
        => new(s.Value * 1000);

    public int IntValue => checked((int)Value);

    //public static implicit operator long(Seconds s)
    //    => s.Value;
    //public static implicit operator Seconds(long s)
    //    => new(s);
}
public readonly record struct SecondsF(double Value)
{
    public static implicit operator TimeSpan(SecondsF s)
        => TimeSpan.FromSeconds(s.Value);

    public static implicit operator MillisecondsF(SecondsF s)
        => new(s.Value * 1000);

    //public static implicit operator double(SecondsF s)
    //    => s.Value;
    //public static implicit operator SecondsF(double s)
    //    => new(s);
}

public readonly record struct Minutes(long Value)
{
    public static implicit operator TimeSpan(Minutes m)
        => TimeSpan.FromMinutes(m.Value);

    public static implicit operator Seconds(Minutes m)
        => new(m.Value * 60);

    public int IntValue => checked((int)Value);

    //public static implicit operator long(Minutes m)
    //    => m.Value;
    //public static implicit operator Minutes(long h)
    //    => new(h);
}
public readonly record struct MinutesF(double Value)
{
    public static implicit operator TimeSpan(MinutesF m)
        => TimeSpan.FromMinutes(m.Value);

    public static implicit operator SecondsF(MinutesF m)
        => new(m.Value * 60);

    //public static implicit operator double(MinutesF m)
    //    => m.Value;
    //public static implicit operator MinutesF(double h)
    //    => new(h);
}

public readonly record struct Hours(int Value)
{
    public static implicit operator TimeSpan(Hours h)
        => TimeSpan.FromHours(h.Value);

    public static implicit operator Minutes(Hours h)
        => new(h.Value * 60);

    public static implicit operator Seconds(Hours h)
        => new(h.Value * 3600);

    //public static implicit operator int(Hours h)
    //    => h.Value;
    //public static implicit operator Hours(int h)
    //    => new(h);
}
public readonly record struct HoursF(double Value)
{
    public static implicit operator TimeSpan(HoursF h)
        => TimeSpan.FromHours(h.Value);

    public static implicit operator MinutesF(HoursF h)
        => new(h.Value * 60);

    public static implicit operator SecondsF(HoursF h)
        => new(h.Value * 3600);

    //public static implicit operator double(HoursF h)
    //    => h.Value;
    //public static implicit operator HoursF(double h)
    //    => new(h);
}

public readonly record struct Days(int Value)
{
    public static implicit operator TimeSpan(Days d)
        => TimeSpan.FromDays(d.Value);

    public static implicit operator Hours(Days d)
        => new(d.Value * 24);

    //public static implicit operator int(Days d)
    //    => d.Value;
    //public static implicit operator Days(int d)
    //    => new(d);
}
public readonly record struct DaysF(double Value)
{
    public static implicit operator TimeSpan(DaysF d)
        => TimeSpan.FromDays(d.Value);

    public static implicit operator HoursF(DaysF d)
        => new(d.Value * 24);

    //public static implicit operator double(DaysF d)
    //    => d.Value;
    //public static implicit operator DaysF(double d)
    //    => new(d);
}

public readonly record struct Months(int Value)
{
    // days for months require more info

    //public static implicit operator int(Months m)
    //    => m.Value;
    //public static implicit operator Months(int m)
    //    => new(m);
}

public readonly record struct Years(int Value)
{
    public static implicit operator Months(Years y)
        => new(y.Value * 12);

    //public static implicit operator int(Years y)
    //    => y.Value;
    //public static implicit operator Years(int y)
    //    => new(y);
}
