public class Pet : IBirthable
{
    public string Name { get; set; }
    public string BirthDay { get; }

    public Pet(string name, string birthDay)
    {
        Name = name;
        BirthDay = birthDay;
    }
}