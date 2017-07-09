namespace _06.Animals
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var animals = new List<Animal>();
            string animalType;

            while ((animalType = Console.ReadLine()) != "Beast!")
            {
                var currentAnimalTokens = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    switch (animalType.Trim())
                    {
                        case "Cat":
                            Animal cat = new Cat(currentAnimalTokens[0], int.Parse(currentAnimalTokens[1]), currentAnimalTokens[2]);
                            animals.Add(cat);
                            break;
                        case "Dog":
                            Animal dog = new Dog(currentAnimalTokens[0], int.Parse(currentAnimalTokens[1]), currentAnimalTokens[2]);
                            animals.Add(dog);
                            break;
                        case "Frog":
                            Animal frog = new Frog(currentAnimalTokens[0], int.Parse(currentAnimalTokens[1]), currentAnimalTokens[2]);
                            animals.Add(frog);
                            break;
                        case "Kitten":
                            Animal kitten = new Kitten(currentAnimalTokens[0], int.Parse(currentAnimalTokens[1]));
                            animals.Add(kitten);
                            break;
                        case "Tomcat":
                            Animal tomcat = new Tomcat(currentAnimalTokens[0], int.Parse(currentAnimalTokens[1]));
                            animals.Add(tomcat);
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); ;
                }
            }
            
            foreach (var creature in animals)
            {
                Console.WriteLine(creature.GetType().Name);
                Console.WriteLine($"{creature.Name} {creature.Age} {creature.Gender}");
                creature.ProduceSound();
            }
        }
    }
}
