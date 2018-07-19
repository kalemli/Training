using System;
using System.Linq;
using System.Reflection;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuItems = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(dpType => dpType.IsSubclassOf(typeof(DesignPattern)))
                .Select(dpType =>
                {
                    var dp = Activator.CreateInstance(dpType) as DesignPattern;
                    return new ConsoleMenuItem<DesignPattern>($"{dp.Category.ToUpper()}.{dp.Name}", MenuCallback, dp);
                })
                .OrderBy(dp => dp.UnderlyingObject.Category);
            var menu = new ConsoleMenu<DesignPattern>($"Design Patterns", menuItems);
            menu.RunConsoleMenu();

            Console.ReadKey();
        }

        private static void MenuCallback(DesignPattern designPattern)
        {
            Console.Clear();
            designPattern.ShowExample();
        }
    }
}
