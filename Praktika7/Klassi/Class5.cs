using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi
{
    public class MyArray1
    {
        private int[] array;

        public MyArray1(int[] arr)
        {
            array = arr;
        }

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public int Length
        {
            get { return array.Length; } // Add this property to return the length of the array
        }

        public static bool operator ==(MyArray1 arr1, MyArray1 arr2)
        {
            return arr1.array.SequenceEqual(arr2.array);
        }

        public static bool operator !=(MyArray1 arr1, MyArray1 arr2)
        {
            return !(arr1 == arr2);
        }

        public static MyArray1 operator +(MyArray1 arr1, MyArray1 arr2)
        {
            // Implement the addition of arrays here
            // Your code here
            return new MyArray1(new int[arr1.Length]); // Replace with the actual implementation
        }
    }


}