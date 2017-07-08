namespace _03.Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
       // private const int workerLastNameMinLength = 3;
        private const int workerWeekMinSalary = 10;
        private const int workerMinWorkingHours = 1;
        private const int workerMaxWorkingHours = 12;

        private decimal weekSalary;
        private decimal workingHours;

        public Worker(string firstName, string lastName, decimal salary, decimal workingHours)
            : base(firstName, lastName)
        {
            this.WeekSalary = salary;
            this.WorkingHours = workingHours;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value <= workerWeekMinSalary)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }

        public decimal WorkingHours
        {
            get
            {
                return this.workingHours;
            }
            set
            {
                if (value < workerMinWorkingHours || value > workerMaxWorkingHours)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workingHours = value;
            }
        }

        public string SalaryperHour()
        {
            var paymentPerDay = this.WeekSalary / 5;
            return $"{paymentPerDay / this.WorkingHours:F2}";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("First Name: ").AppendLine(this.FirstName)
                .Append("Last Name: ").AppendLine(this.LastName)
                .Append("Week Salary: ").AppendLine($"{this.WeekSalary:F2}")
                .Append("Hours per day: ").AppendLine($"{this.WorkingHours:F2}")
                .Append("Salary per hour: ").AppendLine(SalaryperHour())
                .AppendLine();

            return sb.ToString();
        }
    }
}
