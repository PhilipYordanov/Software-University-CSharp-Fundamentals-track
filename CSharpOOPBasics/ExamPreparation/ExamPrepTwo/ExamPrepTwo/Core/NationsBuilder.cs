using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private Dictionary<string, Nation> nations;
    private List<string> warHistoryRecord;

    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>
        {
            {"Air",new Nation() },
            {"Fire",new Nation() },
            {"Earth",new Nation() },
            {"Water",new Nation() }
        };
        this.warHistoryRecord = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        var benderType = benderArgs[0];
        var benderName = benderArgs[1];
        var benderPower = int.Parse(benderArgs[2]);
        var benderAuxParam = double.Parse(benderArgs[3]);
        Bender currentBender;

        switch (benderType)
        {
            case "Air":
                currentBender = new AirBender(benderName, benderPower, benderAuxParam);
                this.nations[benderType].AddBender(currentBender);
                break;
            case "Water":
                currentBender= new WaterBender(benderName, benderPower, benderAuxParam);
                this.nations[benderType].AddBender(currentBender);
                break;
            case "Fire":
                currentBender = new FireBender(benderName, benderPower, benderAuxParam);
                this.nations[benderType].AddBender(currentBender);
                break;
            case "Earth":
                currentBender = new EarthBender(benderName, benderPower, benderAuxParam);
                this.nations[benderType].AddBender(currentBender);
                break;
            default:
                throw new ArgumentException();
        }
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        var monumentType = monumentArgs[0];
        var monumentName = monumentArgs[1];
        var monumentPower = int.Parse(monumentArgs[2]);
        Monument currentMonument;
        switch (monumentType)
        {
            case "Air":
                currentMonument = new AirMonument(monumentName, monumentPower);
                this.nations[monumentType].AddMonument(currentMonument);
                break;
            case "Water":
                currentMonument= new WaterMonument(monumentName, monumentPower);
                this.nations[monumentType].AddMonument(currentMonument);
                break;
            case "Fire":
                currentMonument= new FireMonument(monumentName, monumentPower);
                this.nations[monumentType].AddMonument(currentMonument);
                break;
            case "Earth":
                currentMonument= new EarthMonument(monumentName, monumentPower);
                this.nations[monumentType].AddMonument(currentMonument);
                break;
            default:
                throw new ArgumentException();
        }
    }

    public string GetStatus(string nationsType)
    {
        StringBuilder message = new StringBuilder();

        message
            .AppendLine($"{nationsType} Nation")
            .Append(this.nations[nationsType]);

        return message.ToString();
    }

    public void IssueWar(string nationsType)
    {
        double victoriusWar = this.nations.Max(nation => nation.Value.GetTotalPower());

        foreach (var nation in this.nations.Values)
        {
            if (nation.GetTotalPower()==victoriusWar)
            {
               continue;
            }
            else
            {
                nation.DeclareDefeat();
            }
        }

        this.warHistoryRecord.Add($"War {this.warHistoryRecord.Count + 1} issued by {nationsType}");
    }

    public string GetWarsRecord()
    {
        return string.Join(Environment.NewLine, this.warHistoryRecord);
    } 
}