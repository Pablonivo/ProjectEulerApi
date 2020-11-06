using System;
using System.Numerics;

namespace Data.Entities
{
    public struct Fraction
    {
        public BigInteger Numerator { get; }

        public BigInteger Denominator { get; }

        public Fraction(BigInteger numerator, BigInteger denominator) : this()
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
            }

            var greatestCommonDivisor = ComputeGreatestCommonDivisor(numerator, denominator);
            Numerator = numerator / greatestCommonDivisor;
            Denominator = denominator / greatestCommonDivisor;
        }

        public static implicit operator Fraction(BigInteger integer)
        {
            return new Fraction(integer);
        }

        public static implicit operator Fraction(long integer)
        {
            return new Fraction(integer);
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator + a.Denominator * b.Numerator, a.Denominator * b.Denominator);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
        }

        public static Fraction operator +(BigInteger integer, Fraction fraction)
        {
            return new Fraction(integer) + fraction;
        }

        public static Fraction operator /(BigInteger integer, Fraction fraction)
        {
            return new Fraction(integer) / fraction;
        }

        private Fraction(BigInteger integer)
        {
            Numerator = integer;
            Denominator = 1;
        }

        private BigInteger ComputeGreatestCommonDivisor(BigInteger a, BigInteger b)
        {
            if (b == 0)
            {
                return a;
            }

            return ComputeGreatestCommonDivisor(b, a % b);
        }
    }
}
