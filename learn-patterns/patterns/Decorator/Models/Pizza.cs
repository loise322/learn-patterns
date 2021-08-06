using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Decorator.Models
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }

        public Pizza(string name) 
        {
            Name = name;
        }

        public abstract int GetCost();
    }
}
