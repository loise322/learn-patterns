using patterns.Decorator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Decorator
{
    public class CheesePizza : IPizza
    {
        protected IPizza _pizza;
        public CheesePizza(IPizza pizza)
        {
            _pizza = pizza;
        }

        public void Cook()
        {
            _pizza.Cook();
            Console.WriteLine("Добавили сыра");
        }
    }
}
