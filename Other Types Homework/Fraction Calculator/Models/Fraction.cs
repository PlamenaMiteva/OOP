using System;

namespace Fraction_Calculator.Models
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator):this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }
        public long Numerator{get; set; }

        public long Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value ==0)
                {
                    throw new ArgumentOutOfRangeException("Denominator cannot be 0.");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            long smallestDivisor = GetSmallestCommonDivisor(fraction1, fraction2);
            long multiplier = 0;
            if (fraction1.Denominator < smallestDivisor)
            {
                multiplier = smallestDivisor / fraction1.Denominator;
                fraction1.Numerator = multiplier * (fraction1.Numerator);
                fraction1.Denominator = multiplier * (fraction1.Denominator);
            }
            if (fraction2.Denominator < smallestDivisor)
            {
                multiplier = smallestDivisor / fraction2.Denominator;
                fraction2.Numerator = multiplier * (fraction2.Numerator);
                fraction2.Denominator = multiplier * (fraction2.Denominator);
            }

            Fraction result = new Fraction(fraction1.Numerator + fraction2.Numerator, smallestDivisor);

            return result;
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            long smallestDivisor = GetSmallestCommonDivisor(fraction1, fraction2);
            long multiplier = 0;
            if (fraction1.Denominator < smallestDivisor)
            {
                multiplier = smallestDivisor / fraction1.Denominator;
                fraction1.Numerator = multiplier * (fraction1.Numerator);
                fraction1.Denominator = multiplier * (fraction1.Denominator);
            }
            if (fraction2.Denominator < smallestDivisor)
            {
                multiplier = smallestDivisor / fraction2.Denominator;
                fraction2.Numerator = multiplier * (fraction2.Numerator);
                fraction2.Denominator = multiplier * (fraction2.Denominator);
            }
            long fractionNominator = fraction1.Numerator > fraction2.Numerator ? fraction1.Numerator - fraction2.Numerator : fraction2.Numerator - fraction1.Numerator;
            Fraction result = new Fraction(fractionNominator, smallestDivisor);

            return result;
        }


        private static long GetSmallestCommonDivisor(Fraction a, Fraction b)
        {
            long i = a.Denominator;
            long j = b.Denominator;

            long greaterNumber = 0;
            long smallerNumber = 0;

            if (i > j)
            {
                greaterNumber = i; 
                smallerNumber = j;
            }
            else if (i < j)
            {
                greaterNumber = j; 
                smallerNumber = i;
            }
            else
            {
                return i;
            }
            for (int iterator = 1; iterator <= smallerNumber; iterator++)
            {
                if ((greaterNumber * iterator) % smallerNumber == 0)
                {
                    return iterator * greaterNumber;
                }
            }
            return 0;
        }

        public override string ToString()
        {
            return string.Format("{0:0.00}",(double)this.Numerator/this.Denominator);
        }
    }
}
