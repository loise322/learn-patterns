using patterns.Decorator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Decorator
{
    public class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza pizza) : base($"CheesePizza({pizza.Name})", pizza)
        {
        }

        public override int GetCost()
        {
            return _pizza.GetCost() + 10;
        }
    }
}
