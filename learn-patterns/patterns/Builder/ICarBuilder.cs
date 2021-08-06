using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Builder
{
    public interface ICarBuilder
    {
        void BuildExterior();

        void BuildInterior();

        void BuildMechanics();
    }
}
