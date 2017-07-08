using System.Text;
using System.Text.RegularExpressions;
using System;

namespace _02.Book_Shop
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                var authorNames = value.Split();
                if (authorNames.Length != 2)
                {
                    this.author = value;
                }
                else
                {
                    var secondName = authorNames[1];
                    string pattern = @"\b\d";
                    if (Regex.IsMatch(secondName, pattern))
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                    else
                    {
                        this.author = $"{authorNames[0]} {authorNames[1]}";
                    }
                }
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Type: ").AppendLine(this.GetType().Name)
                .Append("Title: ").AppendLine(this.Title)
                .Append("Author: ").AppendLine(this.Author)
                .Append("Price: ").Append($"{this.Price:f1}")
                .AppendLine();

            return sb.ToString();
        }
    }
}
