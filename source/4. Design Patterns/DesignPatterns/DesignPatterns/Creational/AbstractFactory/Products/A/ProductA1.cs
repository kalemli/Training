﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Products.A
{
    public class ProductA1 : AbstractProductA
    {
        public override void Show()
        {
            Console.WriteLine("Product A1");
        }
    }
}
