using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Products.B
{
    public class ProductB1 : AbstractProductB
    {
        public override void Show()
        {
            Console.WriteLine("Product B1");
        }
    }
}
