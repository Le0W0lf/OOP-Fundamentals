using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Fundamentals
{
    public interface IMyInt
    {
    }
    public class Class1
    {
        internal int MyProperty { get; set; }
        public int a;
        public Class1():this(0)
        {
            Console.WriteLine("zero");
        }
        public Class1(int _a):this(_a,_a)
        {
            Console.WriteLine(_a);
        }
        public Class1(int _a,int _b)
        {
            Console.WriteLine($"{_a} {_b}");
        }
        public void V()
        { Console.WriteLine("zero"); }
        public void V(int v)
        { Console.WriteLine(v); }
    }
}
