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
            Pizza russianPizza = new RussianPizza();
            russianPizza = new TomatoPizza(russianPizza);
            russianPizza = new CheesePizza(russianPizza);
            Console.WriteLine($"Пицца: {russianPizza.Name}, Стоимость: {russianPizza.GetCost()}");
            Console.WriteLine();

            Console.WriteLine("Декорирование итальянской пиццы в томатную");
            Pizza italianPizza = new ItalianPizza();
            italianPizza = new TomatoPizza(italianPizza);
            Console.WriteLine($"Пицца: {italianPizza.Name}, Стоимость: {italianPizza.GetCost()}");
            Console.WriteLine();
        }
    }
}
