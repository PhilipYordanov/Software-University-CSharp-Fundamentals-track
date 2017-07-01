namespace _11.Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Trainer> listOfTrainers = ReadData();

            PrintResult(listOfTrainers);
        }

        private static List<Trainer> ReadData()
        {
            string input;
            var listOfTrainers = new List<Trainer>();
            // caught pokemons 
            while ((input = Console.ReadLine()) != "Tournament")
            {
                var tokens = input
                    .Split();
                string currentTrainerName;
                Pokemon currentPokemon;
                Trainer currentTrainer;

                if (!listOfTrainers.Exists(x => x.Name == tokens[0]))
                {
                    currentTrainerName = tokens[0];
                    currentPokemon = new Pokemon(tokens[1], tokens[2], double.Parse(tokens[3]));
                    currentTrainer = new Trainer(currentTrainerName, currentPokemon);
                    listOfTrainers.Add(currentTrainer);
                }
                else
                {
                    currentPokemon = new Pokemon(tokens[1], tokens[2], double.Parse(tokens[3]));
                    listOfTrainers
                        .Where(x => x.Name == tokens[0])
                        .First()
                        .Pokemons
                        .Add(currentPokemon);
                }
            }

            // tournament 
            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var trainer in listOfTrainers)
                {
                    if (trainer.Pokemons.Any(x => x.Element == input))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        trainer
                            .Pokemons
                            .Select(x => x.Health -= 10)
                            .ToList()
                            .RemoveAll(x => x <= 0);
                    }
                }
            }

            return listOfTrainers;
        }

        private static void PrintResult(List<Trainer> listOfTrainers)
        {
            listOfTrainers
                .OrderByDescending(x => x.NumberOfBadges)
                .ToList()
                .ForEach(x => Console.WriteLine($@"{x.Name} {x.NumberOfBadges} {x.Pokemons.Where(p => p.Health >= 0)
                .ToList()
                .Count()}"));
        }
    }
}
