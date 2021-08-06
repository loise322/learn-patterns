using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Builder
{
    public class CarDirector
    {
        private ICarBuilder _carBuilder;

        public CarDirector(ICarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }

        public void BuildCarcassCar()
        {
            _carBuilder.BuildExterior();
            _carBuilder.BuildInterior();
        }

        public void BuildMechanicCar()
        {
            _carBuilder.BuildMechanics();
        }

        public void BuildWorkingCar()
        {
            _carBuilder.BuildExterior();
            _carBuilder.BuildInterior();
            _carBuilder.BuildMechanics();
        }
    }
}
