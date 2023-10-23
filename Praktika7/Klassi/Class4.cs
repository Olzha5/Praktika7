using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi
{
    public class MyArray
    {
        private int[] array;

        public MyArray(int[] arr)
        {
            array = arr;
        }

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public int Length => array.Length;

        public static bool operator ==(MyArray arr1, MyArray arr2)
        {
            return arr1.array.SequenceEqual(arr2.array);
        }

        public static bool operator !=(MyArray arr1, MyArray arr2)
        {
            return !(arr1 == arr2);
        }

        public static MyArray operator *(MyArray arr1, MyArray arr2)
        {
            // Implement the multiplication of arrays here
            // Your code here
            return new MyArray(new int[arr1.Length]); // Replace with the actual implementation
        }

        public bool Compare(MyArray other)
        {
            // Implement the comparison logic here
            // Your code here
            return false; // Replace with the actual comparison logic
        }
    }


}