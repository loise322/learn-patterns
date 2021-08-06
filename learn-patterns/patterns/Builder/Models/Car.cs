using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Builder.Models
{
    public class Car
    {
        public CarExterior Exterior { get; set; }

        public CarInterior Interior { get; set; }

        public CarMechanics Mechanics { get; set; }

        public Car()
        {
            Exterior = new CarExterior();
            Interior = new CarInterior();
            Mechanics = new CarMechanics();
        }
    }
}
