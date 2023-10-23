using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi
{
    public class MyClass
    {
        public int Property1 { get; set; }
        public string Property2 { get; set; }

        public static bool operator ==(MyClass obj1, MyClass obj2)
        {
            return obj1.Property1 == obj2.Property1 && obj1.Property2 == obj2.Property2;
        }

        public static bool operator !=(MyClass obj1, MyClass obj2)
        {
            return !(obj1 == obj2);
        }

        public override bool Equals(object obj)
        {
            if (obj is MyClass other)
            {
                return this == other;
            }
            return false;
        }
    }

}