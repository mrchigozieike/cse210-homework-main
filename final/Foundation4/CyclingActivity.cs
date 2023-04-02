public class CyclingActivity : Activity
{
    private double speed;

    public CyclingActivity(DateTime date, int length, double speed)
        : base(date, length)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return speed * (length / 60.0);
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override TimeSpan GetPace()
    {
        return TimeSpan.FromSeconds((60.0 / speed) * DistancePerPaceUnit);
    }

    protected override string DistanceUnit => "mi";
    protected override string SpeedUnit => "mph";
    private const double DistancePerPaceUnit = 1.0;
}