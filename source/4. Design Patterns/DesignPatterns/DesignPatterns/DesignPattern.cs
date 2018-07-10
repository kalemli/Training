using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class DesignPattern
    {
        public abstract string Category { get; }
        public abstract string Name { get; }
        public abstract void ShowExample();
    }
}
