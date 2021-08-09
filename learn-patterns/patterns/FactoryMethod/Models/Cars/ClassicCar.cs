using patterns.FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.FactoryMethod.Models.Cars
{
    public class ClassicCar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Классическая машина");
        }
    }
}
