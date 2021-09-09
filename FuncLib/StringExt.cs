using System;
using static LaYumba.Functional.F;
using Unit = System.ValueTuple;

namespace FuncLib
{
    public static class StringExt
    {
        public static Unit WriteLine(this string s)
        {
            Console.WriteLine(s);
            return Unit();
        }
    }
}