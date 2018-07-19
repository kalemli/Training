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
    public class Factory1 : AbstractFactory
    {
        public override AbstractProductA GetProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB GetProductB()
        {
            return new ProductB1();
        }

        public override AbstractProductC GetProductC()
        {
            return new ProductC1();
        }
    }
}
