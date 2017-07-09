namespace _06.Animals
{
    using System;

    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, "Female")
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Miau");
        }
    }
}
