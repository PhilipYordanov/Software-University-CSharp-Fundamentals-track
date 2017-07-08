namespace _05.MordorsCrueltyPlan
{
    using _05.MordorsCrueltyPlan.FoodModels;
    using _05.MordorsCrueltyPlan.MoodModels;
    using System.Collections.Generic;
    using System.Linq;

    public static class MoodFactory
    {
        public static Mood CreateMood(List<Food> food)
        {
            var moodComparer = food.Sum(f => f.FoodPoints);

            if (moodComparer < -5)
            {
                return new Angry();
            }
            else if (moodComparer >= -5 && moodComparer <= 0)
            {
                return new Sad();
            }
            else if (moodComparer >= 1 && moodComparer <= 15)
            {
                return new Happy();
            }
            else
            {
                return new JavaScript();
            }
        }
    }
}