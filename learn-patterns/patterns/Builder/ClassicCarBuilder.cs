using patterns.Builder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Builder
{
    public class ClassicCarBuilder : ICarBuilder
    {
        private Car _car;
        
        public ClassicCarBuilder()
        {
            _car = new Car();
        }

        public void BuildExterior()
        {
            _car.Exterior = new CarExterior
            {
                BodyColor = "ClassicColours",
                BodyType = "Classic",
                GlassType = "Classic"
            };
        }
        public void BuildInterior()
        {
            _car.Interior = new CarInterior
            {
                SeatCount = 4,
                StyleInterior = "Classic"
            };
        }
        public void BuildMechanics()
        {
            _car.Mechanics = new CarMechanics
            {
                Engine = "Classic",
                SparkPlugs = "Classic",
                TransmissionType = "Mechanic"
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
