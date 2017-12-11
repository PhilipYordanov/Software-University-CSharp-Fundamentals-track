using FastFood.Data;
using System.Linq;

namespace FastFood.DataProcessor
{
    public static class Bonus
    {
        public static string UpdatePrice(FastFoodDbContext context, string itemName, decimal newPrice)
        {
            var inputItem = context.Items.FirstOrDefault(x => x.Name == itemName);

            if (inputItem == null)
            {
                return $"Item {itemName} not found!";
            }

            var oldPrice = inputItem.Price;
            inputItem.Price = newPrice;
            context.Update(inputItem);
            return $"{inputItem.Name} Price updated from ${oldPrice:F2} to ${newPrice:F2}";
        }
    }
}
