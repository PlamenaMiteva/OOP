using System;

namespace Human_Student_Worker.Models
{
    public abstract class Human
    {
        private string fname;
        private string lname;

        protected Human(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
        }

        public string FirstName
        {
            get
            {
                return this.fname;
            }
            protected set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The first name field cannot be empty.");
                }
                else
                {
                    this.fname = value;
                }

            }
        }

        public string LastName
        {
            get
            {
                return this.lname;
            }
            protected set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The last name field cannot be empty.");
                }
                else
                {
                    this.lname = value;
                }

            }
        }
    }
}
