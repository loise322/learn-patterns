using patterns.FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.FactoryMethod
{
    public class SportCarCreator : Creator
    {
        public SportCarCreator(string name) : base(name)
        {
        }

        public override Car CreateCar()
        {
            return new SportCar();
        }
    }
}
