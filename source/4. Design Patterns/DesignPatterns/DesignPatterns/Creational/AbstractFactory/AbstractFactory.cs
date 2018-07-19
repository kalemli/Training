﻿using DesignPatterns.Creational.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA GetProductA();
        public abstract AbstractProductB GetProductB();
        public abstract AbstractProductC GetProductC();
    }
}
