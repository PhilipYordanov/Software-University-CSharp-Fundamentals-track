using System.Text;

public class Ferrari :ICar
{
    public string Driver { get; }

    public Ferrari(string driver)
    {
        Driver = driver;
    }

    public string Model()
    {
        return "488-Spider";
    }

    public string UseBrakes()
    {
        return "Brakes!";
    }

    public string PushTheGasPedal()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"{Model()}/{UseBrakes()}/{PushTheGasPedal()}/{this.Driver}");
        return sb.ToString().Trim();
    }
}