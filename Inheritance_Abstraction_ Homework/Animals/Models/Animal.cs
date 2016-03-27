namespace Animals.Models
{
    using System;

    public abstract class Animal:ISoundProducible
    {
        protected string name;
        protected int age;
        protected Gender gender;

        protected Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        protected Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }


        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name field cannot be empty.");
                }
                else
                {
                    this.name = value;
                }

            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            protected set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("The age field cannot be negative.");
                }
                else
                {
                    this.age = value;
                }

            }
        }

        public Gender Gender { get; set; }

        public abstract void ProduceSound();
    }
}
