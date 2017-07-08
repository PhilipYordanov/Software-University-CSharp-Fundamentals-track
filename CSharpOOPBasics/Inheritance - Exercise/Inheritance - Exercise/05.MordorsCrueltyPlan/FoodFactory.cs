namespace _05.MordorsCrueltyPlan
{
    using _05.MordorsCrueltyPlan.FoodModels;

    // usually the factory class is static witch mean its initialize when we build our program and we cant create new instance
    public static class FoodFactory
    {
        // creating food based on the current input param
        public static Food Create(string food)
        {
            switch (food.ToLower())
            {
                case "cram":
                    return new Cram();

                case "lembas":
                    return new Lembas();

                case "apple":
                    return new Apple();

                case "melon":
                    return new Melon();

                case "honeycake":
                    return new HoneyCake();

                case "mushrooms":
                    return new Mushrooms();

                default:
                    return new Other();
            }
        }
    }
}