using System;

namespace _04.Shopping_Spree
{
    public class Product
    {
        private string name;
        private decimal price;
       
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"{nameof(Name)} cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Money cannot be negative");
                }
                this.price = value;
            }
        }

        public Product(string name,decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
