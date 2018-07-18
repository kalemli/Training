using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class Circle : Shape
    {
        public Circle(DrawingImplementor implementor)
            : base(implementor)
        {

        }
    }
}
