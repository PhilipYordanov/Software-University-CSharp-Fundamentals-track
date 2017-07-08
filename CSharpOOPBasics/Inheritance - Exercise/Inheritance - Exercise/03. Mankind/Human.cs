namespace _03.Mankind
{
    using System.Text.RegularExpressions;
    using System;

    public class Human
    {
        private const int humanFirstNameMinLength = 3;
        private const int humanLastNameMinLength = 2;

        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                string pattern = @"\b[A-Z]+";
                string input = value;
                if (!Regex.IsMatch(input,pattern))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: {nameof(firstName)}");
                }
                if (value.Length <= humanFirstNameMinLength )
                {
                    throw new ArgumentException($"Expected length at least 4 symbols! Argument: {nameof(firstName)}");
                }
                this.firstName = value;
            }
        }

        public virtual string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                string pattern = @"\b[A-Z]+";
                string input = value;
                if (!Regex.IsMatch(input, pattern))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: {nameof(lastName)}");
                }
                if (value.Length <= humanLastNameMinLength)
                {
                    throw new ArgumentException($"Expected length at least 3 symbols! Argument: {nameof(lastName)}");
                }
                this.lastName = value;
            }
        }
    }
}
