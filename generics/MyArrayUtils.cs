using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    internal class MyArrayUtils<T>
    {
        public T[] mass = new T[3];


        public T this [int index]
        {
            get { return mass [index]; }
            set { mass [index] = value; }   
        }

        public static void Print(T[]mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine($"Элеменнт [{i}] = {mass[i]}") ;
            }
        }

        public static void Reverse(T[] mass)
        {
            for(int i = mass.Length - 1; i >= 0; i--)
            {
                mass[mass.Length - 1 - i] = mass[i];
            }
        }


    }
}
