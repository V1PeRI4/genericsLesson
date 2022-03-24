using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();

            box.Value = "Hello";

            Box<string>.PrintT(box.Value);



            Console.WriteLine("------------------------------------");



            MyArrayUtils<int> myArrayUtils = new MyArrayUtils<int>();

            myArrayUtils.mass[0] = 0; 
            myArrayUtils.mass[1] = 1;
            myArrayUtils.mass[2] = 2;

            MyArrayUtils<int>.Print(myArrayUtils.mass);


            Console.WriteLine("------------------------------------");

            MyArrayUtils<int>.Reverse(myArrayUtils.mass);
            MyArrayUtils<int>.Print(myArrayUtils.mass);
        }
    }
}
