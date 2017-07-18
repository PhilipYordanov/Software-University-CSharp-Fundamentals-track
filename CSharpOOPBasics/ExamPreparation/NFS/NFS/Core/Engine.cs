using System;

public class Engine
{
    private CarManager maneger;

    public Engine()
    {
        this.maneger = new CarManager();
    }

    public void Run()
    {

        string command;

        while ((command = Console.ReadLine()) != "Cops Are Here")
        {
            var tokens = command
                .Split();

            int id;
            string type;
            int raceId;

            switch (tokens[0])
            {
                case "register":
                    id = int.Parse(tokens[1]);
                    type = tokens[2];
                    string brand = tokens[3];
                    string model = tokens[4];
                    int yearOfProduction = int.Parse(tokens[5]);
                    int horsepower = int.Parse(tokens[6]);
                    int acceleration = int.Parse(tokens[7]);
                    int suspension = int.Parse(tokens[8]);
                    int durability = int.Parse(tokens[9]);
                    maneger.Register(id, type, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                    break;
                case "check":
                    Console.WriteLine(maneger.Check(int.Parse(tokens[1])));
                    break;
                case "open":
                    id = int.Parse(tokens[1]);
                    type = tokens[2];
                    int length = int.Parse(tokens[3]);
                    string route = tokens[4];
                    int prizePool = int.Parse(tokens[5]);
                    maneger.Open(id, type, length, route, prizePool);
                    break;
                case "participate":
                    var carId = int.Parse(tokens[1]);
                    raceId = int.Parse(tokens[2]);
                    maneger.Participate(carId, raceId);
                    break;
                case "start":
                    raceId = int.Parse(tokens[1]);
                    Console.WriteLine(maneger.Start(raceId));
                    break;
                case "park":
                    id = int.Parse(tokens[1]);
                    maneger.Park(id);
                    break;
                case "unpark":
                    break;
                case "tune":
                    break;
            }
        }
    }
}