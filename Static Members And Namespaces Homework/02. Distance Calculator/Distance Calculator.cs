namespace _02.Distance_Calculator
{
    using System;
    using Models;

    public class DistanceCalculator
    {
        private static void Main()
        {
           Console.WriteLine(String.Format("{0:0.00}",Calculator.CalculateDistanceBetweenTwoPoints(
                new Point(2, 5.78), new Point(-89, 4))));

           Console.WriteLine(String.Format("{0:0.00}", Calculator.CalculateDistanceBetweenTwoPoints(
               new Point(34.5, 0), new Point(4.589, -43))));
        }
    }
}

