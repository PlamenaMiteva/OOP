using System;

namespace Human_Student_Worker.Models
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;
       
        public Worker(string fname, string lname, decimal weekSalary, double workHoursPerDay)
            : base(fname, lname)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Week Salary cannot be negative.");
                }
                else
                {
                    this.weekSalary = value;
                }

            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("Work hours should be in range [0...24].");
                }
                else
                {
                    this.workHoursPerDay = value;
                }

            }
        }

        public decimal MoneyPerHour
        {
            get
            {
                return this.weekSalary/(decimal)this.WorkHoursPerDay;
            }
            
        }

        public override string ToString()
        {
            var result = this.MoneyPerHour.ToString("#.##") + " - " + this.FirstName + " " + this.LastName;
            return result;
        }
    }
}
