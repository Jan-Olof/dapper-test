using System;
using System.Collections.Generic;
using Unit = System.ValueTuple;
using static LaYumba.Functional.F;

namespace FuncLib
{
    public static class EnumerableExt
    {
        public static Unit ReadLine<T>(this IEnumerable<T> e)
        {
            Console.ReadLine();
            return Unit();
        }

        public static Unit ReadLine<T>(this T t)
        {
            Console.ReadLine();
            return Unit();
        }
    }
}