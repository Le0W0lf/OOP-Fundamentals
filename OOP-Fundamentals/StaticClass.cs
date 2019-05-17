using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OOP_Fundamentals
{
   
    static class ChildClass
    {
        public static void Print(this IMyInterfice s)
        {
            Console.WriteLine(s.GetFirstName().Tr()+' ' + s.GetSecondName().Tr());
        }

        public static string Tr(this string s)
        {
            return s.Trim();
        }

        public static IEnumerable<(T1, T2)> CrossJoin<T1, T2>(this IEnumerable<T1> sub1, IEnumerable<T2> sub2, Func<T1, T2,bool> lb)
        {
            var res = (from x in sub1
                       from y in sub2
                       where lb(x,y)
                       select (x, y));//.ToList();
            return res;
        }


    }
    
}
