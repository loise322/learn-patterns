using patterns.AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.AbstractFactory
{
    public class AbstractFactoryService
    {
        public void TestAbstractFactory()
        {
            Console.WriteLine("Тест абстрактной фабрики:");
            Console.WriteLine();

            Console.WriteLine("Создание летающего транспорта:");
            Machine flyMachine = new Machine(new FlyMachineFactory());
            flyMachine.Drive();
            flyMachine.FIll();
            Console.WriteLine();

            Console.WriteLine("Создание наземного транспорта:");
            Machine landMachine = new Machine(new LandMachineFactory());
            landMachine.Drive();
            landMachine.FIll();
            Console.WriteLine();
        }
    }
}
