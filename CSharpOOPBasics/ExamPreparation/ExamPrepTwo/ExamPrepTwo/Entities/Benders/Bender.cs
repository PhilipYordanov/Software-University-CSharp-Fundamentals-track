public abstract class Bender
{
    private string name;
    private int power;

    protected Bender(string name, int power)
    {
        this.name = name;
        this.power = power;
    }

    public int Power
    {
        get => this.power;
        set => this.power = value;
    }

    public abstract double GetPower();

    public override string ToString()
    {
        string benderType = this.GetType().Name;
        int typeEnd = benderType.IndexOf("Bender");
        benderType = benderType.Insert(typeEnd, " ");

        return $"{benderType}: {this.name}, Power: {this.Power}";
    }
}