using patterns.Decorator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Decorator
{
    public abstract class PizzaDecorator : Pizza
    {
        protected Pizza _pizza;
        public PizzaDecorator(string name, Pizza pizza): base(name)
        {
            _pizza = pizza;
        }
    }
}
