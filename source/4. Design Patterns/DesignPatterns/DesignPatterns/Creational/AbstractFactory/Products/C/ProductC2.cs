﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Products.C
{
    public class ProductC2 : AbstractProductC
    {
        public override void Show()
        {
            Console.WriteLine("Product C2");
        }
    }
}
