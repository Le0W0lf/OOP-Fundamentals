using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Fundamentals
{
    public class MyClass:IMyInterfice
    {
        protected internal int QQQ;
        internal int MyProperty { get; set; }
        public int a;
        protected string FirstName, SecondName;
        public MyClass():this("Bilbo","Beggins")
        {
            //Console.WriteLine("zero");
        }
        public MyClass(string s1,string s2)//:this(_a,_a)
        {
            QQQ = 0;
            FirstName = s1;
            SecondName = s2;
            //Console.WriteLine(_a);
        }
        /*public Class1(int _a,int _b)
        {
            Console.WriteLine($"{_a} {_b}");
        }*/
        public void V()
        { Console.WriteLine("zero"); }
        public void V(int v)
        { Console.WriteLine(v); }
        
        public void Write()
        {
            Console.WriteLine("private write");
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetSecondName()
        {
            return SecondName;
        }
    }
}
