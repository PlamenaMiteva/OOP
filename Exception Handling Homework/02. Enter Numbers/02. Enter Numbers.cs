using System;

class EnterNumbers
    {
        static void Main()
        {     
            ReadNumber(0, 100, 10);
        }
        public static void ReadNumber(int start, int end, int numberOfInputNumbers)
        {
            int counter = 0;
            while(counter < numberOfInputNumbers)
            {
                Console.WriteLine("Please enter a number value in the range [{0}....{1}]:", start, end);
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number < start)
                    {
                        Console.WriteLine("Invalid number. The input number should be greater than {0}.", start);
                    }
                    else if (number > end)
                    {
                        Console.WriteLine("Invalid number. The input number should be less than {0}.", end);
                    }
                        start = number;
                        counter++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number format");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid number");
                }
            }

        }
    }

