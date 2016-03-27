using System;

namespace _02.Distance_Calculator.Models
{
    public class Calculator
    {
        public static double CalculateDistanceBetweenTwoPoints(Point A, Point B)
        {
            double distance = Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));

            return distance;
        }
    }
}

