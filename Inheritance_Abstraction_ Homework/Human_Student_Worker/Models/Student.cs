using System;

namespace Human_Student_Worker.Models
{
    public class Student:Human
    {
        private const string Pattern = "[A-Za-z0-9]{5,10}";
        private string facultyNumber;

        public Student(string fname, string lname, string fnumber) : base(fname, lname)
        {
            this.FacultyNumber = fnumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The faculty number field cannot be empty.");
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(value, Pattern))
                {
                    throw new ArgumentException("The faculty number field should contain letters and digits only.");
                }
                else
                {
                    this.facultyNumber = value;
                }

            }
        }

        public override string ToString()
        {
            var result = this.FacultyNumber + " - " + this.FirstName + " " + this.LastName;
            return result;
        }
    }
}
