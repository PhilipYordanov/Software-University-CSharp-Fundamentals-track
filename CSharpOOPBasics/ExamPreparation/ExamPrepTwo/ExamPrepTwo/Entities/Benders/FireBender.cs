public class FireBender : Bender
{
    private double heatAggression;

    public FireBender(string name, int power, double heatAggression)
        : base(name, power)
    {
        this.heatAggression = heatAggression;
    }

    public override double GetPower()
    {
        return this.heatAggression * this.Power;
    } 

    public override string ToString()
    {
        return $"{base.ToString()}, Heat Aggression: {this.heatAggression:F2}";
    }
}