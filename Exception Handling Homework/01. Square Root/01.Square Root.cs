using System;

class SquareRoot
{
    static void Main()
    {

        try
        {
            int number = int.Parse(Console.ReadLine());
            double squareRoot = Math.Sqrt(number);
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("Sqrt for negative numbers is undefined!");
            }
            Console.WriteLine(squareRoot);
        }
        catch (FormatException)
        {
            throw new Exception("Invalid number format");
        }
        catch (OverflowException)
        {
            throw new Exception("Invalid number");
        }
        finally
        {

            Console.WriteLine("Good bye");
        }
    }
}

