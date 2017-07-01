using System;
using System.Globalization;

namespace _05.Date_Modifier
{
    class DateModifier
    {
        private string firstDate;
        private string secondDate;

        public string FirstDate
        {
            get
            {
                return this.firstDate;
            }
            set
            {
                this.firstDate = value;
            }
        }

        public string SecondDate
        {
            get
            {
                return this.secondDate;
            }
            set
            {
                this.secondDate = value;
            }
        }

        public DateModifier(string firstDate, string secondDate)
        {
            this.FirstDate = firstDate;
            this.SecondDate = secondDate;
        }

        public void DaysDifference(DateModifier currentDate)
        {
            var first = DateTime.ParseExact(firstDate,"yyyy MM dd",CultureInfo.InvariantCulture);
            var second = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture); 
            Console.WriteLine( Math.Abs((first - second).TotalDays));
        }
    }
}
