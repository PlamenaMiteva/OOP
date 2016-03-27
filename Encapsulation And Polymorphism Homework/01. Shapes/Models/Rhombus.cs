namespace _01.Shapes.Models
{
    public class Rhombus : BasicShape
    {
        public override double CalculateArea()
        {
            return Width*Height;
        }

        public override double CalculatePerimetar()
        {
            return 4 * Width;
        }
    }
}
