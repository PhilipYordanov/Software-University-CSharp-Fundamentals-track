using System;
using System.Collections.Generic;
using System.Linq;

public class Country
{
    public string CountyName { get; set; }

    public Dictionary<string, long> CityPopulation = new Dictionary<string, long>();
}

public class PopulationCounter
{
    public static void Main()
    {
        string input;
        var countries = new List<Country>();

        while ((input = Console.ReadLine()) != "report")
        {
            var tokens = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var cityName = tokens[0];
            var countyName = tokens[1];
            var population = long.Parse(tokens[2]);

            Country currentCountry = new Country();

            if (countries.Any(x => x.CountyName == countyName))
            {
                for (int i = 0; i < countries.Count; i++)
                {
                    if (countries[i].CountyName == countyName)
                    {
                        countries[i].CityPopulation.Add(cityName, population);
                    }
                }
            }
            else
            {
                currentCountry.CountyName = countyName;
                currentCountry.CityPopulation.Add(cityName, population);
                countries.Add(currentCountry);
            }
        }

        foreach (var country in countries.OrderByDescending(x => x.CityPopulation.Values.Sum()))
        {
            var currentCountryName = country.CountyName;
            var currentCountryPopulation = country.CityPopulation.Values.Sum();

            Console.WriteLine($"{currentCountryName} (total population: {currentCountryPopulation})");

            foreach (var kvp in country.CityPopulation.OrderByDescending(x => x.Value))
            {
                var currentCityName = kvp.Key;
                var currentCityPopulation = kvp.Value;

                Console.WriteLine($"=>{currentCityName}: {currentCityPopulation}");
            }
        }
    }
}