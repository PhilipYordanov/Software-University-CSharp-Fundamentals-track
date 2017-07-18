using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Race
{
    public int Length { get; set; }
    public string Route { get; set; }
    public int PrizePool { get; set; }
    public Dictionary<int, Car> Participants { get; set; }
    public List<Car> Winners { get; set; }

    public Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.Participants = new Dictionary<int, Car>();
        this.Winners = new List<Car>();
    }

    public abstract int GetPerformance(int id);

    public Dictionary<int, Car> GetWinners()
    {
        var winners = this.Participants
             .OrderByDescending(n => this.GetPerformance(n.Key))
             .Take(3)
             .ToDictionary(x => x.Key, y => y.Value);

        return winners;
    }

    public List<int> GetPrizes()
    {
        var result  = new List<int>();
        result.Add((this.PrizePool * 50) / 100);
        result.Add((this.PrizePool * 30) / 100);
        result.Add((this.PrizePool * 20) / 100);
        return result;
    }

    public string StartRace()
    {
        var winners = GetWinners();
        var prizes = GetPrizes();

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{Route} - {Length}");

        for (int i = 0; i < winners.Count; i++)
        {
            var car = winners.ElementAt(i);
            sb.AppendLine($"{i+1}. {car.Value.Brand} {car.Value.Model} {this.GetPerformance(car.Key)}PP - ${prizes[i]}");
        }

        return sb.ToString().Trim();
    }
}