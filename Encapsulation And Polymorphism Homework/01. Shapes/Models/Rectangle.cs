namespace _01.Shapes.Models
{
    public class Rectangle : BasicShape

    {
        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimetar()
        {
            return (Width + Height) * 2;
        }
    }
}
