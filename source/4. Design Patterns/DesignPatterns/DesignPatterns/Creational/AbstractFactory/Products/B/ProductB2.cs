using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Products.B
{
    public class ProductB2 : AbstractProductB
    {
        public override void Show()
        {
            Console.WriteLine("Product B2");
        }
    }
}
