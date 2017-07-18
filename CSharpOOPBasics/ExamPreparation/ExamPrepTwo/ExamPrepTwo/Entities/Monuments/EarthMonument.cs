public class EarthMonument : Monument
{
    private int earthAffinity;

    public EarthMonument(string name, int earthAffinity)
        : base(name)
    {
        this.earthAffinity = earthAffinity;
    }

    public override int GetAffinity()
    {
       return this.earthAffinity;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Earth Affinity: {this.earthAffinity}";
    }
}