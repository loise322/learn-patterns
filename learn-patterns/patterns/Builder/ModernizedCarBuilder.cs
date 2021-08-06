using patterns.Builder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Builder
{
    public class ModernizedCarBuilder: ICarBuilder
    {
        private Car _car;

        public ModernizedCarBuilder()
        {
            _car = new Car();
        }

        public void BuildExterior()
        {
            _car.Exterior = new CarExterior
            {
                BodyColor = "UncommonColours",
                BodyType = "Modernized",
                GlassType = "Modernized"
            };
        }
        public void BuildInterior()
        {
            _car.Interior = new CarInterior
            {
                SeatCount = 2,
                StyleInterior = "Modernized"
            };
        }
        public void BuildMechanics()
        {
            _car.Mechanics = new CarMechanics
            {
                Engine = "Modernized",
                SparkPlugs = "Modernized",
                TransmissionType = "Auto"
            };
        }

        public Car GetResult()
        {
            Car result = _car;
            _car = new Car();
            return result;
        }
    }
}
