using System;
using Models;

class Point3D
{
    static void Main()
    {
        Point p1 = new Point(2, 5.6, -8.45);
        Point p2 = new Point(-78, 2.56, -100);
        Console.WriteLine("Starting Point: " + Point.StartingPoint);
        Console.WriteLine("Point: " + p1);
        Console.WriteLine("Point: " + p2);
    }
}

