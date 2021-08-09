using patterns.Decorator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Decorator
{
    public class PizzaService
    {
        public void TestPizzaDecorator()
        {
            Console.WriteLine("Тест декоратора пиццы:");
            Console.WriteLine();

            Console.WriteLine("Декорирование русской пиццы сначало в томатную, потом в сырную");
            IPizza russianPizza = new RussianPizza();
            russianPizza = new TomatoPizza(russianPizza);
            russianPizza = new CheesePizza(russianPizza);
            russianPizza.Cook();
            Console.WriteLine();

            Console.WriteLine("Декорирование итальянской пиццы в томатную");
            IPizza italianPizza = new ItalianPizza();
            italianPizza = new TomatoPizza(italianPizza);
            italianPizza.Cook();
            Console.WriteLine();
        }
    }
}
