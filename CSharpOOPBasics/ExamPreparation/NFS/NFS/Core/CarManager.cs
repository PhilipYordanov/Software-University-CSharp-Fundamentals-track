using System.Collections.Generic;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private Garage garage;

    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.races = new Dictionary<int, Race>();
        this.garage = new Garage();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        if (type == "Performance")
        {
            this.cars.Add(id, new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
        }
        else
        {
            this.cars.Add(id, new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
        }
    }

    public string Check(int id)
    {
        return cars[id].ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        switch (type)
        {
            case "Casual":
                this.races.Add(id, new CasualRace(length, route, prizePool));
                break;
            case "Drift":
                this.races.Add(id, new DriftRace(length, route, prizePool));
                break;
            case "Drag":
                this.races.Add(id, new DragRace(length, route, prizePool));
                break;
        }
    }

    public void Participate(int carId, int raceId)
    {
        if (!garage.ParkedCars.Contains(carId))
        {
            this.races[raceId].Participants.Add(carId, cars[carId]);
        }
    }

    public string Start(int id)
    {
        return races[id].StartRace();
    }

    public void Park(int id)
    {
        foreach (var race in races.Values)
        {
            if (!race.Participants.ContainsKey(id))
            {
                this.garage.AddCar(id);
            }
        }
        this.garage.AddCar(id);
    }

    public void Unpark(int id)
    {
        this.garage.Remove(id);
    }

    public void Tune(int tuneIndex, string addOn)
    {

    }
}