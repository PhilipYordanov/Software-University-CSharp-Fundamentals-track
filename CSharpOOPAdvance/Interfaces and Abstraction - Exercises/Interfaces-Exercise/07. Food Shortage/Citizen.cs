public class Citizen : IIdentifiable, IBirthable, IPerson, IBuyer
{
    public string Id { get; }
    public string BirthDay { get; }
    public string Name { get; }
    public int Age { get; }
    public int Food { get; set; }

    public Citizen(string name, int age, string id, string birthDay)
    {
        Id = id;
        BirthDay = birthDay;
        Name = name;
        Age = age;
        Food = 0;
    }

    public int BuyFood()
    {
        return this.Food += 10;
    }
}