using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class Showcase : DesignPattern
    {
        public override string Category => "Structural";

        public override string Name => "Bridge";

        public override void ShowExample()
        {
            var hotApi = new HotDrawingImplementor();
            var coolApi = new CoolDrawingImplementor();

            var hotRectangle = new Rectangle(hotApi);
            var coolRectangle = new Rectangle(coolApi);

            hotRectangle.Draw();
            coolRectangle.Draw();

            Console.ReadKey(true);
        }
    }
}
