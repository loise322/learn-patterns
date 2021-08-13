using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.FactoryMethod.Models
{
    public abstract class Race
    {

        public void TestRoad()
        {
            ICar car = GetCar();
            car.Drive();
        }

        public abstract ICar GetCar();
    }
}
