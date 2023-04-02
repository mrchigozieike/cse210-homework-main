public class SwimmingActivity : Activity
{
    private int laps;

    public SwimmingActivity(DateTime date, int length, int laps)
        : base(date, length)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50.0 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (length / 60.0);
    }

    public override TimeSpan GetPace()
    {
        return TimeSpan.FromSeconds((length * 60.0) / (laps * 50.0));
    }
}
