using System;
using System.Linq;

namespace LinqSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            Console.WriteLine("LINQ");

            var list = new int[] { 97, 92, 81, 60 };

            list.WriteLine();

            list.Where(i => i > 80)
                .ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }
    }
}
