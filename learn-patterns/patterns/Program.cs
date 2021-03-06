using patterns.AbstractFactory;
using patterns.Builder;
using patterns.Decorator;
using patterns.FactoryMethod;
using patterns.FactoryMethod.Models;
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

            FactoryMethodCarService factoryMethodCarService = new FactoryMethodCarService(RoadType.Classic);
            factoryMethodCarService.TestFactoryMethod();

            factoryMethodCarService = new FactoryMethodCarService(RoadType.Sport);
            factoryMethodCarService.TestFactoryMethod();

            AbstractFactoryService abstractFactoryService = new AbstractFactoryService();
            abstractFactoryService.TestAbstractFactory();

            Console.ReadKey();
        }
    }
}
