using patterns.FactoryMethod.Models.Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.FactoryMethod.Models.Methods
{
    public class ClassicRoad : Race
    {
        public override ICar GetCar()
        {
            return new ClassicCar();
        }
    }
}
