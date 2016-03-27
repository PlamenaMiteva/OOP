using System;
using _01.Shapes.Models;


class Shapes
{
    private static void Main()
    {
        IShape[] figures =
        {
            new Rhombus {Width = 6.9, Height = 7.06},
            new Circle(2),
            new Rectangle {Width = 2, Height = 3},
            new Circle (3.5),
            new Rectangle {Width = 2.89, Height = 5.72},
            new Rhombus{Width = 2.5, Height = 4.69},
            new Rectangle {Width = 5.78, Height = 14.7}
        };

        foreach (IShape figure in figures)
        {
            Console.WriteLine(
                "Figure = {0} area = {1:F2},    perimetar = {2:F2}",
                figure.GetType().Name.PadRight(15, ' '),
                figure.CalculateArea(),
                figure.CalculatePerimetar());
        }
    }
}

        
    

