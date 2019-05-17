using System;
using BL;
using System.Linq;

namespace OOP_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass c1 = new MyClass("       Frodo","            Beggins");
            
            //MyClass c2 = new MyClass();
            ////Object o = new Object();
            //c1.Print();
            //c2.Print();
            var s1 = Enumerable.Range(1, 5);
            var s2 = Enumerable.Range(1, 5);
            var res = s1.CrossJoin(s2,(x,y)=>(x*y>10));
            foreach(var t in res)
            {
                Console.WriteLine($"{t.Item1} {t.Item2}");
            }
        }
        
    }
}
