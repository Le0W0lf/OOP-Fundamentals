using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
