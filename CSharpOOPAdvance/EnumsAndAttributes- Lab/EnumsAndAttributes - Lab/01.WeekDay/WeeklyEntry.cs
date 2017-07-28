using System;

public class WeeklyEntry :IComparable<WeeklyEntry>
{
    private Weekday weekday;

    public Weekday Weekday => this.weekday;
    public string Notes { get; private set; }

    public WeeklyEntry(string weekday,string note)
    {
        Enum.TryParse(weekday, out this.weekday);
        this.Notes = note;
    }

    public int CompareTo(WeeklyEntry other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var weekdayComparison = this.weekday.CompareTo(other.weekday);
        if (weekdayComparison != 0) return weekdayComparison;
        return string.Compare(this.Notes, other.Notes, StringComparison.Ordinal);
    }

    public override string ToString()
    {
        return $"{this.Weekday} - {this.Notes}";
    }
}