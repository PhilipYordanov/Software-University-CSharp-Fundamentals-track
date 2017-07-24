public class Citizen : IIdentifiable, IBirthable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Id { get; }
    public string BirthDay { get; }

    public Citizen(string name, int age, string id, string birthDay)
    {
        Name = name;
        Age = age;
        Id = id;
        BirthDay = birthDay;
    }
}