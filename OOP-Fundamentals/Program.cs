using System;
using BL;

namespace OOP_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass c1 = new MyClass("       Frodo","            Beggins");
            MyClass c2 = new MyClass();
            //Object o = new Object();
            c1.Print();
            c2.Print();
        }
        
    }
}
