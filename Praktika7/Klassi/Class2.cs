using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi
{
    public class ArrayClass
    {
        private int[] array;

        public ArrayClass(int[] arr)
        {
            array = arr;
        }

        public static bool operator <(ArrayClass obj1, ArrayClass obj2)
        {
            return obj1.array.Sum() < obj2.array.Sum();
        }

        public static bool operator >(ArrayClass obj1, ArrayClass obj2)
        {
            return obj1.array.Sum() > obj2.array.Sum();
        }
    }

}