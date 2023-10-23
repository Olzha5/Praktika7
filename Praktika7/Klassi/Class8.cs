using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi
{
    public struct Frac
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Frac(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public static Frac operator +(Frac frac1, Frac frac2)
        {
            // Реализация сложения дробей
            return new Frac(frac1.Numerator * frac2.Denominator + frac2.Numerator * frac1.Denominator,
                frac1.Denominator * frac2.Denominator);
        }

        public static Frac operator -(Frac frac1, Frac frac2)
        {
            // Реализация вычитания
            return new Frac(frac1.Numerator * frac2.Denominator - frac2.Numerator * frac1.Denominator,
                frac1.Denominator * frac2.Denominator);
        }

        public static Frac operator *(Frac frac1, Frac frac2)
        {
            // Реализация умножения
            return new Frac(frac1.Numerator * frac2.Numerator, frac1.Denominator * frac2.Denominator);
        }

        public static Frac operator /(Frac frac1, Frac frac2)
        {
            // Реализация деления
            return new Frac(frac1.Numerator * frac2.Denominator, frac1.Denominator * frac2.Numerator);
        }

        public static implicit operator double(Frac frac)
        {
            // Приведение Frac к double
            return (double)frac.Numerator / frac.Denominator;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Frac other)
            {
                return Numerator == other.Numerator && Denominator == other.Denominator;
            }
            return false;
        }

        public static bool operator ==(Frac frac1, Frac frac2)
        {
            return frac1.Equals(frac2);
        }

        public static bool operator !=(Frac frac1, Frac frac2)
        {
            return !frac1.Equals(frac2);
        }
    }


}