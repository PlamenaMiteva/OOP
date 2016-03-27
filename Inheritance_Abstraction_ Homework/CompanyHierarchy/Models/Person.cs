namespace CompanyHierarchy.Models
{
    using System;
    using CompanyHierarchy.Interfaces;

    public abstract class Person : IPerson
    {
        private int id;
        private string fname;
        private string lname;


        protected Person(int id, string fname, string lname)
        {
            this.Id = id;
            this.FirstName = fname;
            this.LastName = lname;
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The id field cannot be negative.");
                }
                else
                {
                    this.id = value;
                }

            }
        }

        public string FirstName
        {
            get
            {
                return this.fname;
            }
            set
            {
                this.ValidateName(value, "First");
                this.fname = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lname;
            }
            set
            {
                this.ValidateName(value, "Last");
                this.lname = value;
            }
        }

        private void ValidateName(string name, string nameIdentifier)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException
                    (String.Format("{0} name field cannot be null, empty or whitespace." ,nameIdentifier));
            }
        }

    }
}
