using patterns.AbstractFactory;
using patterns.Builder;
using patterns.Decorator;
using patterns.FactoryMethod;
using System;

namespace patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CarService carService = new CarService();
            carService.TestCarBuilder();

            PizzaService pizzaService = new PizzaService();
            pizzaService.TestPizzaDecorator();

            FactoryMethodCarService factoryMethodCarService = new FactoryMethodCarService();
            factoryMethodCarService.TestFactoryMethod();

            AbstractFactoryService abstractFactoryService = new AbstractFactoryService();
            abstractFactoryService.TestAbstractFactory();

            Console.ReadKey();
        }
    }
}
