using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class Rectangle: Shape
    {
        public Rectangle(DrawingImplementor implementor)    
            : base(implementor)    
        {
     
        }
    }
}
