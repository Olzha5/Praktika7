using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi
{
    public class MyDecimal
    {
        private char[] digits = new char[100];

        public MyDecimal(string value)
        {
            // Инициализация объекта из строки
        }

        public MyDecimal(char[] digits)
        {
            // Инициализация объекта из массива цифр
        }

        public static MyDecimal operator +(MyDecimal num1, MyDecimal num2)
        {
            // Реализация сложения
            return new MyDecimal("0"); // Замените на реальную реализацию
        }

        public static MyDecimal operator -(MyDecimal num1, MyDecimal num2)
        {
            // Реализация вычитания
            return new MyDecimal("0"); // Замените на реальную реализацию
        }

        public static MyDecimal operator *(MyDecimal num1, MyDecimal num2)
        {
            // Реализация умножения
            return new MyDecimal("0"); // Замените на реальную реализацию
        }

        public static MyDecimal operator /(MyDecimal num1, MyDecimal num2)
        {
            // Реализация деления
            return new MyDecimal("0"); // Замените на реальную реализацию
        }
    }

}