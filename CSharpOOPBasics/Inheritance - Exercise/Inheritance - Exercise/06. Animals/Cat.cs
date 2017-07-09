﻿namespace _06.Animals
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("MiauMiau");
        }
    }
}