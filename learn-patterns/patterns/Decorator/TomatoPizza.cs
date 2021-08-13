using patterns.Decorator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Decorator
{
    public class TomatoPizza : IPizza
    {
        protected IPizza _pizza;
        public TomatoPizza(IPizza pizza)
        {
            _pizza = pizza;
        }

        public void Cook()
        {
            _pizza.Cook();
            Console.WriteLine("Добавили томатов");
        }
    }
}
