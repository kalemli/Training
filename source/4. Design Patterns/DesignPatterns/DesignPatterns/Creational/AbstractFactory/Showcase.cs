using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Showcase : DesignPattern
    {
        public override string Category => "Creational";

        public override string Name => "AbstractFactory";

        public override void ShowExample()
        {
            AbstractFactory factory1 = new Factory1();
            AbstractFactory factory2 = new Factory2();

            ShowProducts(factory1);
            ShowProducts(factory2);
        }

        public void ShowProducts(AbstractFactory factory)
        {
            factory.GetProductA().Show();
            factory.GetProductB().Show();
            factory.GetProductC().Show();
        }
    }
}
