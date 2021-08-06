using patterns.Decorator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Decorator
{
    public class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza pizza) : base($"TomatoPizza({pizza.Name})", pizza)
        {
        }

        public override int GetCost()
        {
            return _pizza.GetCost() + 5;
        }
    }
}
