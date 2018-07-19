using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Creational.AbstractFactory.Products;
using DesignPatterns.Creational.AbstractFactory.Products.A;
using DesignPatterns.Creational.AbstractFactory.Products.B;
using DesignPatterns.Creational.AbstractFactory.Products.C;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    public class Factory2 : AbstractFactory
    {
        public override AbstractProductA GetProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB GetProductB()
        {
            return new ProductB2();
        }

        public override AbstractProductC GetProductC()
        {
            return new ProductC2();
        }
    }
}
