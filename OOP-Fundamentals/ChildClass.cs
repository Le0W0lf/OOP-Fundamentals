using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Fundamentals
{
    static class ChildClass
    {
        public static string trim(this string s)
        {
            return s.Trim();
        }
    }
}
