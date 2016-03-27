namespace _01.Shapes.Models
{
    using System;

    public class Circle : IShape
    {
        private double radius; 
        
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Radius cannot be negative.");
                }
                this.radius = value;
            }
        }

        double IShape.CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        double IShape.CalculatePerimetar()
        {
            return Math.PI * this.Radius * 2;
        }
    }
}
