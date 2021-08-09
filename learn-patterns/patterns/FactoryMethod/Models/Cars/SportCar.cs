using patterns.FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.FactoryMethod.Models.Cars
{
    public class SportCar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Спортивная машина");
        }
    }
}
