namespace _05.MordorsCrueltyPlan.FoodModels
{
    public abstract class Food
    {
        private int foodPoints;

        public virtual int FoodPoints
        {
            get
            {
                return foodPoints;
            }
            set
            {
               this.foodPoints = value;
            }
        }

        public Food(int foodPoints)
        {
            this.FoodPoints = foodPoints;
        }
    }
}