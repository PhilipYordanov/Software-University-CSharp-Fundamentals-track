public class Child : Person
{
    public Child(string name, int age)
    : base(name, age)
    {
    }

    public override int Age
    {
        get
        {
            return base.Age;
        }

        set
        {
            //TODO validate childs age
            base.Age = value;
        }
    }
}