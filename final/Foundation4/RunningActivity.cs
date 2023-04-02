
public class RunningActivity : Activity
{
    private double distance;

    public RunningActivity(DateTime date, int length, double distance)
        : base(date, length)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (length / 60.0);
    }

    public override TimeSpan GetPace()
    {
        return TimeSpan.FromSeconds((length * 60.0) / distance);
    }
}

