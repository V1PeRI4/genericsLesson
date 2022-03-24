using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    internal class Box<T>
    {
        private T _value;

        public T Value { get => _value; set => _value = value; }
        
        public static void PrintT(T value)
        {
            Console.WriteLine(value.ToString());
        }
    }
}
