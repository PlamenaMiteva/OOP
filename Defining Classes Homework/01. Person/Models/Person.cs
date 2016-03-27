namespace Models
{
    using System;

    public class Person
    {
        private int age;
        private string email;
        private string name;

        public Person(string name, int age, string email = null)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)

                    throw new ArgumentException("Age should be in range [1...100]");

                this.age = value;

            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (!value.Contains("@") && !string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid email address!");
                }
                this.email = value;
            }
        }


        public override string ToString()
        {

            if (!string.IsNullOrEmpty(this.Email))
            {
                return "Student: " + this.Name + " Age: " + this.Age + " Email: " + this.Email;
            }
            else
            {
                return "Student: " + this.Name + " Age: " + this.Age;
            }
        }
    }
}
