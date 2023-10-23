using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi
{
    public class Money
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public static Money operator +(Money money1, Money money2)
        {
            // Реализация сложения денег в разных валютах
            // При необходимости конвертируйте одну валюту в другую по заданному курсу
            return new Money { Amount = money1.Amount + money2.Amount, Currency = "USD" };
        }

        public static bool operator ==(Money money1, Money money2)
        {
            return money1.Amount == money2.Amount && money1.Currency == money2.Currency;
        }

        public static bool operator !=(Money money1, Money money2)
        {
            return !(money1 == money2);
        }
    }

}