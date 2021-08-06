using patterns.FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.FactoryMethod
{
    public class FactoryMethodCarService
    {
        public void TestFactoryMethod()
        {
            Console.WriteLine("Тест фабричного метода:");
            Console.WriteLine();

            Console.WriteLine("Создаем классическую машину:");
            Creator creator = new ClassicCarCreator("Производитель классических авто");
            Car classicCar = creator.CreateCar();
            Console.WriteLine($"Создана: {classicCar.Name} от {creator.Name} (Type: {classicCar.GetType()})");
            Console.WriteLine();

            Console.WriteLine("Создаем спортивную машину:");
            creator = new SportCarCreator("Производитель спортивных авто");
            Car sportCar = creator.CreateCar();
            Console.WriteLine($"Создана: {sportCar.Name} от {creator.Name} (Type: {sportCar.GetType()})");
            Console.WriteLine();
        }
    }
}
