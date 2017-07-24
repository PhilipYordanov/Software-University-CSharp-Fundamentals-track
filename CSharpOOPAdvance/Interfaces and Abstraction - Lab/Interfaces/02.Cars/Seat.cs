using System.Text;

public class Seat : ICar
{
    public string Model { get; }
    public string Color { get; }

    public Seat(string model, string color)
    {
        Model = model;
        Color = color;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Color} {GetType().Name} {this.Model}")
            .AppendLine(this.Start())
            .AppendLine(this.Stop());
        return sb.ToString().Trim();
    }

    public string Start()
    {
        return "Engine Start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }
}