using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqSamples
{
    public static class UtilExtensions
    {
        public static void WriteLine(this int[] array)
        {
            array.ForEach(el => Console.Write(el + " "));
        }

        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
                action(item);
        }
    }
}
