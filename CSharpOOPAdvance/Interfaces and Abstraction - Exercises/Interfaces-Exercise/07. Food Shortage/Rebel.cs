public class Rebel : IPerson,IGroupable,IBuyer
{
    // name, age and group
    public string Name { get; }
    public int Age { get; }
    public string Group { get; }
    public int Food { get; set; }

    public Rebel(string name, int age, string @group)
    {
        Name = name;
        Age = age;
        Group = @group;
        Food = 0;
    }

    public int BuyFood()
    {
       return this.Food += 5;
    }
}