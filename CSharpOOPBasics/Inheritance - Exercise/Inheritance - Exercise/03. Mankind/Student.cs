namespace _03.Mankind
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Student : Human
    {
        private const int FacultyNumberMinLength = 5;
        private const int FacultyNumberMaxLength = 10;

        private string facultyNumber;

        public Student(string firstName, string lastname, string facultyNumber)
            : base(firstName, lastname)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                string pattern = @"^[a-zA-Z0-9]+$";
                if (!Regex.IsMatch(value,pattern))
                {
                    throw new ArgumentException($"Invalid faculty number!");
                }
                if (value.Length < FacultyNumberMinLength || value.Length > FacultyNumberMaxLength )
                {
                    throw new ArgumentException($"Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("First Name: ").AppendLine(this.FirstName)
                .Append("Last Name: ").AppendLine(this.LastName)
                .Append("Faculty number: ").AppendLine(this.FacultyNumber)
                .AppendLine();

            return sb.ToString();
        }
    }
}
