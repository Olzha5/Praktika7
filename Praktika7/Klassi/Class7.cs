using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi
{
    public struct Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public static Complex operator +(Complex c1, Complex c2)
        {
            // Реализация сложения комплексных чисел
            return new Complex { Real = c1.Real + c2.Real, Imaginary = c1.Imaginary + c2.Imaginary };
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            // Реализация вычитания
            return new Complex { Real = c1.Real - c2.Real, Imaginary = c1.Imaginary - c2.Imaginary };
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            // Реализация умножения
            return new Complex
            {
                Real = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary,
                Imaginary = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real
            };
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            // Реализация деления
            double denominator = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
            return new Complex
            {
                Real = (c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / denominator,
                Imaginary = (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / denominator
            };
        }

        public static Complex FromDouble(double realValue)
        {
            return new Complex { Real = realValue, Imaginary = 0 };
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

        public override bool Equals(object obj)
        {
            if (obj is Complex other)
            {
                return Real == other.Real && Imaginary == other.Imaginary;
            }
            return false;
        }

        public static bool operator ==(Complex c1, Complex c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Complex c1, Complex c2)
        {
            return !c1.Equals(c2);
        }
    }

}