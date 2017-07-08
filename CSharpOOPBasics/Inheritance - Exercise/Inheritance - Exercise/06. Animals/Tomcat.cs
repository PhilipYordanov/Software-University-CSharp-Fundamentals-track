namespace _06.Animals
{
    using System;

    class Tomcat : Cat
    {
        public Tomcat(string name, int age, string gender)
            : base(name, age, gender)
        {
            base.Gender = "Male";
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Give me one million b***h");
        }
    }
}
