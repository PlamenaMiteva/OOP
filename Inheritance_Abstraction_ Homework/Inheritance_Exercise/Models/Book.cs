namespace Inheritance_Exercise.Models
{
    using System;
    using System.Text;

    public class Book
    {
        private string title;
        private string author;
        private double price;

        public Book(string title, string author, double price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            protected set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The title cannot be empty.");
                }
                else
                {
                    this.title = value;
                }

            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            protected set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The author cannot be empty.");
                }
                else
                {
                    this.author = value;
                }
            }
        }

        public virtual double Price
        {
            get
            {
                return this.price;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be negative.");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("-Type: {0}{1}", this.GetType().Name, Environment.NewLine);
            output.AppendFormat("-Title: {0}{1}", this.Title, Environment.NewLine);
            output.AppendFormat("-Author: {0}{1}", this.Author, Environment.NewLine);
            output.AppendFormat("-Price: {0}{1}", this.Price, Environment.NewLine);
            return output.ToString();
        }
    }
}
