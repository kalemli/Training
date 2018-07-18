using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class CoolDrawingImplementor : DrawingImplementor
    {
        public override void Draw()
        {
            Console.WriteLine("Cool drawing!..");
        }
    }
}
