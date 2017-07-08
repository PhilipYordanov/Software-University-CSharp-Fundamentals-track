namespace _05.MordorsCrueltyPlan
{
    using _05.MordorsCrueltyPlan.FoodModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var listOfFood = new List<Food>();

            var foodList = Console.ReadLine()
                .Split(new[] { ' ', '\t', ';', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var food in foodList)
            {
                listOfFood.Add(FoodFactory.Create(food));
            }

            Console.WriteLine(listOfFood.Sum(food => food.FoodPoints));
            Console.WriteLine(MoodFactory.CreateMood(listOfFood).GetType().Name);
        }
    }
}