using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassi;

namespace Praktika7
{
    internal class Program
    {
        static void Clas1()
        {
            MyClass obj1 = new MyClass { Property1 = 1, Property2 = "A" };
            MyClass obj2 = new MyClass { Property1 = 2, Property2 = "B" };

            if (obj1 == obj2)
            {
                Console.WriteLine("obj1 and obj2 are equal.");
            }
            else
            {
                Console.WriteLine("obj1 and obj2 are not equal.");
            }
        }
        static void Clas2()
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };

            ArrayClass obj1 = new ArrayClass(arr1);
            ArrayClass obj2 = new ArrayClass(arr2);

            if (obj1 < obj2)
            {
                Console.WriteLine("obj1 has a smaller sum of elements than obj2.");
            }
            else if (obj1 > obj2)
            {
                Console.WriteLine("obj1 has a larger sum of elements than obj2.");
            }
            else
            {
                Console.WriteLine("Sums of elements in obj1 and obj2 are equal.");
            }
        }
        static void Clas3()
        {
            Money money1 = new Money { Amount = 100.50m, Currency = "USD" };
            Money money2 = new Money { Amount = 50.25m, Currency = "USD" };

            Money sum = money1 + money2;
            Console.WriteLine($"Sum: {sum.Amount} {sum.Currency}");

            if (money1 == money2)
            {
                Console.WriteLine("The amounts are equal.");
            }
            else
            {
                Console.WriteLine("The amounts are not equal.");
            }
        }
        static void Clas4()
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 1, 2, 3 };

            MyArray myArray1 = new MyArray(arr1);
            MyArray myArray2 = new MyArray(arr2);

            if (myArray1 == myArray2)
            {
                Console.WriteLine("myArray1 and myArray2 are equal.");
            }
            else
            {
                Console.WriteLine("myArray1 and myArray2 are not equal.");
            }

            MyArray product = myArray1 * myArray2;
            Console.WriteLine("Multiplication result: " + string.Join(", ", product));
        }
        static void Clas5()
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };

            MyArray1 myArray1 = new MyArray1(arr1);
            MyArray1 myArray2 = new MyArray1(arr2);

            if (myArray1 == myArray2)
            {
                Console.WriteLine("myArray1 and myArray2 are equal.");
            }
            else
            {
                Console.WriteLine("myArray1 and myArray2 are not equal.");
            }

            MyArray1 sum = myArray1 + myArray2;
            Console.WriteLine("Addition result: " + string.Join(", ", sum));
        }
        static void Clas6()
        {
            MyDecimal num1 = new MyDecimal("12345");
            MyDecimal num2 = new MyDecimal("6789");

            MyDecimal sum = num1 + num2;
            MyDecimal difference = num1 - num2;
            MyDecimal product = num1 * num2;
            MyDecimal quotient = num1 / num2;

            Console.WriteLine("Sum: " + sum.ToString());
            Console.WriteLine("Difference: " + difference.ToString());
            Console.WriteLine("Product: " + product.ToString());
            Console.WriteLine("Quotient: " + quotient.ToString());
        }
        static void Clas7()
        {
            MyDecimal num1 = new MyDecimal("12345");
            MyDecimal num2 = new MyDecimal("6789");

            MyDecimal sum = num1 + num2;
            MyDecimal difference = num1 - num2;
            MyDecimal product = num1 * num2;
            MyDecimal quotient = num1 / num2;

            Console.WriteLine("Sum: " + sum.ToString());
            Console.WriteLine("Difference: " + difference.ToString());
            Console.WriteLine("Product: " + product.ToString());
            Console.WriteLine("Quotient: " + quotient.ToString());
        }
        static void Clas8()
        {
            Frac f1 = new Frac(1, 2);
            Frac f2 = new Frac(3, 4);
            Frac result = f1 + f2; // Результат равен 5/4
            double asDouble = (double)result; // Приведение к double
        }
        static void Main(string[] args)
        {
            Clas1();
            Clas2();
            Clas3();
            Clas4();
            Clas5();
            Clas6();
            Clas7();
            Clas8();
        }
    }
}