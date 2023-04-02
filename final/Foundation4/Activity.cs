public abstract class Activity
{
    protected DateTime date;
    protected int length;

    public Activity(DateTime date, int length)
    {
        this.date = date;
        this.length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract TimeSpan GetPace();
    public virtual string GetSummary()
    {
        string format = "{0} {1} ({2} min)- Distance {3:F1} {4}, Speed {5:F1} {6}/h, Pace: {7:mm\\:ss} min/{4}";
        return string.Format(format, date.ToString("dd MMM yyyy"), GetType().Name, length, GetDistance(), DistanceUnit, GetSpeed(), SpeedUnit, GetPace());
    }

    protected virtual string DistanceUnit => "km";
    protected virtual string SpeedUnit => "kph";
}