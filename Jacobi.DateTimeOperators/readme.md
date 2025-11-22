# DateTime Operators

DateTime
DateTimeOffset
TimeSpan
DateOnly
TimeOnly (add/sub via TimeSpan, except hours/minutes)

Cannot extend standard type with implicit operators.



Ticks
Microseconds
Milliseconds
Seconds
Minutes
Hours
Days
Months
Years

Offset

We're not using TimeSpan.<Factors> (how many seconds in an hour) for our types 
because these fields were introduced in net9.0 (not in net8.0)


Specials:
  DayOfTheWeek
  MonthName  (enum)

time spans
public readonly record struct Weeks(int Value);
public readonly record struct Trimesters(int Value);
public readonly record struct Quarters(int Value);
public readonly record struct Decades(int Value);
public readonly record struct Centuries(int Value);
public readonly record struct Millenia(int Value);
public readonly record struct Eons(int Value);
