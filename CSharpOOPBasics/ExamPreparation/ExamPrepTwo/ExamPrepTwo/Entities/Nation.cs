using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
    private List<Bender> benders;
    private List<Monument> monuments;

    public Nation()
    {
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }

    public double GetTotalPower()
    {
        int monumentsIncreasePower = 0;
        double totalBenderspower = 0.0;

        foreach (var monument in this.monuments)
        {
            monumentsIncreasePower += monument.GetAffinity();
        }

        foreach (var bender in this.benders)
        {
            totalBenderspower += bender.GetPower();
        }

        double totalPowerIncrease = totalBenderspower / 100 * monumentsIncreasePower;
        return totalBenderspower * totalPowerIncrease;
    }

    public void AddBender(Bender bender)
    {
        this.benders.Add(bender);
    }

    public void AddMonument(Monument monument)
    {
        this.monuments.Add(monument);
    }

    public void DeclareDefeat()
    {
        this.benders.Clear();
        this.monuments.Clear();
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append("Benders:");
        if (this.benders.Any())
        {
            result.AppendLine()
                .AppendLine(string.Join(Environment.NewLine, this.benders.Select(bender => $"###{bender}")));
        }
        else
        {
            result.AppendLine(" None");
        }

        result.Append("Monuments:");
        if (this.monuments.Any())
        {
            result.AppendLine()
                .AppendLine(string.Join(Environment.NewLine, this.monuments.Select(monument => $"###{monument}")));
        }
        else
        {
            result.AppendLine(" None");
        }

        return result.ToString().Trim();
    }
}